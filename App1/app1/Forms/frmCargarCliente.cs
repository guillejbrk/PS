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

namespace App1
{
    public partial class frmCargarCliente : MetroForm
    {


        public Cliente ClienteSeleccionado { get; set; }
        public Cliente ClienteActual { get; set; }

        public frmCargarCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Cliente Clientes = new Cliente();
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "" || txtCel.Text == "" ||
                txtEdad.Text == "" || txtDomi.Text == "")

            {
                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                Clientes.Apellido = txtApellido.Text;
                Clientes.Nombre = txtNombre.Text;
                Clientes.Edad = Convert.ToInt64(txtEdad.Text);
                Clientes.Fecha = dtpFecha.Value.ToShortDateString();
                Clientes.Domicilio = txtDomi.Text;
                Clientes.Tel = Convert.ToInt64(txtTel.Text);
                Clientes.Cel = Convert.ToInt64(txtCel.Text);
                Clientes.Correo = txtCorreo.Text;

                int resultado = ClienteDAL.AgregarCliente(Clientes);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK,
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


        private void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDomi.Clear();
            txtCel.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
            txtTel.Clear();

        }

        /*  private void Actualizar_Lista()
        {
            lstCliente.Items.Clear();
            for (int i = 0; i < ind_actual; i++)
                lstCliente.Items.Add(Clientes[i].ToString());
        }*/

        private void Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validar()
        {
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar Apellido...");
                txtApellido.Focus();
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar Nombre...");
                txtApellido.Focus();
                return false;
            }


            return true;
        }



        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }


        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClienteDAL.BuscarClientes(txtBuscar.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Int64 Id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = ClienteDAL.ObtenerCliente2(Id);

            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Cliente");
            }

            if (ClienteSeleccionado != null)
            {
                ClienteActual = ClienteSeleccionado;

                txtApellido.Text = ClienteSeleccionado.Apellido;
                txtNombre.Text = ClienteSeleccionado.Apellido;
                txtEdad.Text = Convert.ToString(ClienteSeleccionado.Edad);
                dtpFecha.Text = ClienteSeleccionado.Fecha;
                txtDomi.Text = ClienteSeleccionado.Domicilio;
                txtTel.Text = Convert.ToString(ClienteSeleccionado.Tel);
                txtCel.Text = Convert.ToString(ClienteSeleccionado.Cel);
                txtCorreo.Text = ClienteSeleccionado.Correo;
                btnGuardar.Enabled = false;

            }





        }

        private void btnACtualizar_Click(object sender, EventArgs e)
        {

            Cliente pCliente = new Cliente();
            pCliente.Apellido = txtApellido.Text;
            pCliente.Nombre = txtNombre.Text;
            pCliente.Edad = Convert.ToInt64(txtEdad.Text);
            pCliente.Fecha = dtpFecha.Value.ToShortDateString();
            pCliente.Domicilio = txtDomi.Text;
            pCliente.Tel = Convert.ToInt64(txtTel.Text);
            pCliente.Cel = Convert.ToInt64(txtCel.Text);
            pCliente.Correo = txtCorreo.Text;
            pCliente.Id = ClienteActual.Id;


            int resultado = ClienteDAL.Modificar(pCliente);

            if (resultado > 0)
            {

                MessageBox.Show("ALumno Modificado con exito", "ALumno Modificado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                limpiar();

                btnGuardar.Enabled = true;
            }

            else
            {
                MessageBox.Show("No se pudo Modificar el alumno", "Ocurrio un error!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }




        }

        

   }
}


     

  
  

