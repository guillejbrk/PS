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
    public partial class frmAdmTratamiento : Form
    {
        public frmAdmTratamiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
      
            Tratamiento Tratamiento = new Tratamiento();

            Tratamiento.Descripcion = textBox1.Text;
            Tratamiento.Costo = Convert.ToDecimal(textBox2.Text);



            int resultado = ConsultorioDAL.AgregarTratamiento(Tratamiento);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Ingresados Correctamente", "Datos Guardados", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo Guardar", "Error al Guardar", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
