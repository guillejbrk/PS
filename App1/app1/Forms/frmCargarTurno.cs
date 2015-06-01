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

            txtMotivo.Visible = false;

            if (rbnCancelado.Checked)
            {
                panelCanelado.Visible = true;
            }
            else
            {
                panelCanelado.Visible = false;
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Turno pTurno = new Turno();

            {

                pTurno.id_Cliente = Convert.ToInt32(cboPaciente.SelectedValue);
                pTurno.id_Tratamiento = Convert.ToInt32(cboTratamiento.SelectedValue);
                pTurno.id_Terapeuta = Convert.ToInt32(cboTerapeuta.SelectedValue);

                if (rbnAlta.Checked == false)
                {
                    pTurno.id_Estado = 1;
                }
                else
                {
                    pTurno.id_Estado = 2;
                }
              
            
        

     /*  int resultado = ConsultorioDAL.AgregarTurno(pTurno);

                if (resultado > 0)
                {
                    MessageBox.Show("Hitoria Guardada Correctamente", "Datos Guardados", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar", "Error al Guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }*/
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

    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        
        //internacionalizacion de idioma cambiar idioma C#
      


     
        

    

      
    }
}
