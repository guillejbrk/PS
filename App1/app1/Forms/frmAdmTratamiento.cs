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
    public partial class frmAdmTratamiento : MetroForm
    {
        public frmAdmTratamiento()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdmTratamiento_Load(object sender, EventArgs e)
        {
            cbmProducto.DataSource = TratamientoDAL.ObtenerProductos();
            cbmProducto.DisplayMember = "Descripcion";
            cbmProducto.ValueMember = "Id";
        }

        private void cbmProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool validar()
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("Debe ingresar Nombre Tratamiento...");
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Debe ingresar Costo Tratamiento...");
                textBox2.Focus();
                return false;
            }


            return true;
        }

        private void btnCargarTratamiento_Click(object sender, EventArgs e)
        {
            Tratamiento pTratamiento = new Tratamiento();
            if (validar())
            {

                pTratamiento.Descripcion = textBox1.Text;
                pTratamiento.Id_Producto = Convert.ToInt64(cbmProducto.SelectedValue);
                pTratamiento.Costo = Convert.ToDecimal(textBox2.Text);


                int resultado = TratamientoDAL.AgregarTratamiento(pTratamiento);

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
        }


    }

}
