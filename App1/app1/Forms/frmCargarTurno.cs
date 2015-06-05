using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App1.Clases;
using App1.Clases.AccesoSQL;
using MetroFramework.Forms;
using System.Globalization;
using System.Threading;

namespace App1.Forms
{
    public partial class frmCargarTurno : MetroForm
    {
       
         
        public frmCargarTurno()
        {
           
            InitializeComponent();
        }

        private void frmCargarTurno_Load(object sender, EventArgs e)
        {
            frmCargarCliente frmCargar = new frmCargarCliente();

          

            cboPaciente.DataSource = ClienteDAL.ObtenerClientes();
            cboPaciente.DisplayMember = "Apellido";
            cboPaciente.ValueMember = "Id";
           

            cboTratamiento.DataSource = TratamientoDAL.ObtenerTratamiento();
            cboTratamiento.DisplayMember = "Descripcion";
            cboTratamiento.ValueMember = "Id";

            cboTerapeuta.DataSource = TerapeutaDAL.ObtenerTerapeuta();
            cboTerapeuta.DisplayMember = "Apellido";
            cboTerapeuta.ValueMember = "Id";

           

            

            if (rbnCancelado.Checked)
            {
                panelCanelado.Visible = true;
            }
            else
            {
                panelCanelado.Visible = false;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            frmCargarCliente frmCargar= new frmCargarCliente();
             frmCargar.ShowDialog();
            
        }    

        private void rbnCancelado_CheckedChanged(object sender, EventArgs e)
        {
            panelCanelado.Visible = true;
            txtMotivo.Visible = true;
        }

        private void rbnAlta_CheckedChanged(object sender, EventArgs e)
        {
            panelCanelado.Visible = false;
        }
        
        private void cboPaciente_MouseClick(object sender, MouseEventArgs e)
        {
            frmCargarCliente frmCargar = new frmCargarCliente();
            cboPaciente.DataSource = ClienteDAL.ObtenerClientes();

            cboPaciente.DisplayMember = "Apellido";
            cboPaciente.ValueMember = "Id";
        }

        private void cboTerapeuta_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            dtgvTurnos.DataSource = TurnosDAL.DiasDeAltaOCancelado(((Terapeuta)cboTerapeuta.SelectedItem).Id);


       
            var cultureInfo = new CultureInfo("es-Ar");
            var dateTimeInfo = cultureInfo.DateTimeFormat;
            var dayNames = dateTimeInfo.DayNames;

            List<string> Listadedias = new List<string>();
            List<DayOfWeek> L = AgendaDAL.ObtenerListaDias(((Terapeuta)cboTerapeuta.SelectedItem).Id);
            foreach (DayOfWeek item in L)
            {
                Listadedias.Add(dayNames[(int)item]);
            }
            cboDia.DataSource = null;
            cboDia.DataSource = Listadedias;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmAdmTratamiento frmCargarTra = new frmAdmTratamiento();
            frmCargarTra.ShowDialog();
        }

        private void cboTratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTratamiento_MouseClick(object sender, MouseEventArgs e)
        {

            cboTratamiento.DataSource = TratamientoDAL.ObtenerTratamiento();
            cboTratamiento.DisplayMember = "Descripcion";
            cboTratamiento.ValueMember = "Id";
        }

        private void lstDias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (lstDias.SelectedItem != null)
            {
                Turno t = (Turno)lstDias.SelectedItem;
                if (t.id_Estado == 3 || t.id_Estado == 2)
                {
                    t.id_Estado = 1;
                    t.id_Tratamiento = ((Tratamiento)cboTratamiento.SelectedItem).Id;
                    t.Motivo = "";
                    t.id_Cliente = ((Cliente)cboPaciente.SelectedItem).Id;
                    TurnosDAL.ActualizarTurno(t);
                    MessageBox.Show("turno Dado de Alta");
                    dtgvTurnos.DataSource = TurnosDAL.DiasDeAltaOCancelado(((Terapeuta)cboTerapeuta.SelectedItem).Id);


                        
                }
                else
                {
                    if (rbnCancelado.Checked)
                    {
                        t.id_Estado = 2;
                        t.id_Tratamiento = ((Tratamiento)cboTratamiento.SelectedItem).Id;
                        t.Motivo = txtMotivo.Text;
                        t.id_Cliente = ((Cliente)cboPaciente.SelectedItem).Id;
                        TurnosDAL.ActualizarTurno(t);
                        MessageBox.Show("turno cancelado");
                    }
                    else
                    {
                        MessageBox.Show("turno ya seleccionado");
                    }
                }
            }
        }

        private void cboDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cultureInfo = new CultureInfo("es-Ar");
            var dateTimeInfo = cultureInfo.DateTimeFormat;
            var dayNames = dateTimeInfo.DayNames;

            DayOfWeek d = DayOfWeekConverter.ConvertBack((string)cboDia.SelectedItem);
            List<Turno> turnosdisponibles = TurnosDAL.ObtenerTurnosDelMes(((Terapeuta)(cboTerapeuta.SelectedItem)).Id, d);
            lstDias.DataSource = null;
            lstDias.DataSource = turnosdisponibles;
            lstDias.DisplayMember = "Feyhora";
        }

        private void lstDias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstDias.SelectedItem != null)
            {
                switch ((((Turno)lstDias.SelectedItem).id_Estado))
                {
                    case 1:
                        rbnAlta.Checked = true;
                        rbnCancelado.Checked = false;
                        rbtInactivo.Checked = false;
                        break;
                    case 2:
                        rbnAlta.Checked = false;
                        rbnCancelado.Checked = true;
                        rbtInactivo.Checked = false;
                        break;
                    case 3:
                        rbnAlta.Checked = false;
                        rbnCancelado.Checked = false;
                        rbtInactivo.Checked = true;
                        break;
                    default:
                        break;
                }
            }

        }
   
      


     
        

    

      
    }
}
