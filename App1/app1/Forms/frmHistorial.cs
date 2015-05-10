using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App1.Clases;

namespace App1.Forms
{
    public partial class frmHistorial : Form
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
            cboCliente.DataSource = ConsultorioDAL.ObtenerClientes();

            cboCliente.DisplayMember = "Apellido";
            cboCliente.ValueMember = "Id";

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Historias pHistorias = new Historias();

            {
                pHistorias.fecha = dtpFecha1.Text;
                pHistorias.Observacion = textBox1.Text;
                pHistorias.id_Cliente = Convert.ToInt32(cboCliente.SelectedValue);


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
