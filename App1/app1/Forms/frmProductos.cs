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
    public partial class frmProductos : MetroForm
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            if (txtProducto.Text == "")
            {
                MessageBox.Show("Debe Completar el campo Descripcion", "Error al Cargar", MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation); ;
                txtProducto.Focus();
                return false;
            }
             
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe Completar el campo Cantidad", "Error al Cargar", MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation); ;
                txtCantidad.Focus();
                return false;

            }
            if (txtCosto.Text == "")
            {
                MessageBox.Show("Debe Completar el campo Costo", "Error al Cargar", MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation); ;
                txtCosto.Focus();
                return false;

            }
            return true;

        }

       

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
          
        }

        private void limpiar()
        {
            txtProducto.Clear();
            txtCantidad.Clear();
            txtCosto.Clear();
          

        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
              if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cboTerapeuta.DataSource = TerapeutaDAL.ObtenerTerapeuta();
            cboTerapeuta.DisplayMember = "Apellido";
            cboTerapeuta.ValueMember = "Id";

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Producto pProducto = new Producto();
                pProducto.Descripcion = txtProducto.Text;
                pProducto.Cantidad = Convert.ToInt64(txtCantidad.Text);
                pProducto.Costo = Convert.ToDecimal(txtCosto.Text);
                pProducto.id_Terapeuta = Convert.ToInt64(cboTerapeuta.SelectedValue);

                int resultado = ProductosDAL.AgregarProducto(pProducto);

                if (resultado > 0)
                {
                    MessageBox.Show("Producto Guardado Correctamente", "Producto Guardado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    limpiar();

                }

                else
                {
                    MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }



            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        


        
    }
}
