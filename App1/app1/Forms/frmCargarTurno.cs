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
            cboCliente.DataSource = ClienteDAL.ObtenerClientes();

            cboCliente.DisplayMember = "Apellido";
            cboCliente.ValueMember = "Id";
           

            cboTratamiento.DataSource = ConsultorioDAL.ObtenerTratamiento();
            cboTratamiento.DisplayMember = "Descripcion";
            cboTratamiento.ValueMember = "Id";

            cboTerapeuta.DataSource = ConsultorioDAL.ObtenerTerapeuta();
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

                pTurno.id_Cliente = Convert.ToInt32(cboCliente.SelectedValue);
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
               
            
        

        int resultado = ConsultorioDAL.AgregarTurno(pTurno);

                if (resultado > 0)
                {
                    MessageBox.Show("Hitoria Guardada Correctamente", "Datos Guardados", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar", "Error al Guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

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



        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmCargarCliente frmCargar = new frmCargarCliente();
            cboCliente.DataSource = ClienteDAL.ObtenerClientes();

            cboCliente.DisplayMember = "Apellido";
            cboCliente.ValueMember = "Id";

            cboTratamiento.DataSource = ConsultorioDAL.ObtenerTratamiento();
            cboTratamiento.DisplayMember = "Descripcion";
            cboTratamiento.ValueMember = "Id";
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
        

    

      
    }
}
