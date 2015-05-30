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
    public partial class frmHistorial : MetroForm
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            cboCliente.DataSource = ClienteDAL.ObtenerClientes();

            cboCliente.DisplayMember = "Apellido";
            cboCliente.ValueMember = "Id";


        }
        private bool validar()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe Completar el campo Observacion", "Error al Cargar", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation); ;
                textBox1.Focus();
                return false;
            }
          

            return true;
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            Historias pHistorias = new Historias();

           if(validar()) {
                pHistorias.Fecha = dtpFecha1.Text;
                pHistorias.Observacion = textBox1.Text;
                pHistorias.idPaciente = Convert.ToInt32(cboCliente.SelectedValue);


                int resultado = ConsultorioDAL.AgregarHistoria(pHistorias);

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

    }
}
