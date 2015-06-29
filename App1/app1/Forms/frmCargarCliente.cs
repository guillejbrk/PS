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
using App1.Forms;

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

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

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
           

    


        public void button1_Click_1(object sender, EventArgs e)
        {
            if (dtgvPaciente.SelectedRows.Count == 1)
            {
                Int64 Id = Convert.ToInt64(dtgvPaciente.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = ClienteDAL.ObtenerCliente2(Id);

            }
            else
            {
                MessageBox.Show("Seleccione Paciente que desea Modificar", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            if (ClienteSeleccionado != null)
            {
                ClienteActual = ClienteSeleccionado;

                txtApellido.Text = ClienteSeleccionado.Apellido;
                txtNombre.Text = ClienteSeleccionado.Nombre;
                txtEdad.Text = Convert.ToString(ClienteSeleccionado.Edad);
                dtpFecha.Text = ClienteSeleccionado.Fecha;
                txtDomi.Text = ClienteSeleccionado.Domicilio;
                txtTel.Text = Convert.ToString(ClienteSeleccionado.Tel);
                txtCel.Text = Convert.ToString(ClienteSeleccionado.Cel);
                txtCorreo.Text = ClienteSeleccionado.Correo;
                btnGuardar.Enabled = false;
                btnActu2.Enabled = true;
             
                metroTabControl1.SelectedIndex = 0;

            }

        }

       

        private void btnGuardar_Click_2(object sender, EventArgs e)
        {
            Cliente Clientes = new Cliente();
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "" || txtCel.Text == "" ||
                txtEdad.Text == "" || txtDomi.Text == "")
            {
                MessageBox.Show("Debe Completar Todos los Campos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                Clientes.Apellido = txtApellido.Text;
                Clientes.Nombre = txtNombre.Text;
                Clientes.Edad = Convert.ToInt64(txtEdad.Text);
                Clientes.Fecha = dtpFecha.Value.ToShortDateString();
                Clientes.Domicilio = txtDomi.Text;
                Clientes.Tel = txtTel.Text;
                Clientes.Cel = txtCel.Text;
                Clientes.Correo = txtCorreo.Text;

                int resultado = ClienteDAL.AgregarCliente(Clientes);

                if (resultado > 0)
                {
                    MessageBox.Show("Paciente Cargado Corerectamente", "Cargado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    btnActu2.Enabled = false;


                    limpiar();

                }

                else
                {
                    MessageBox.Show("No se pudo Cargar el Paciente", "Error al Cargar", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }

            }

        }

        private void frmCargarCliente_Load(object sender, EventArgs e)
        {
            btnActu2.Enabled = false;
         
            metroTabControl1.SelectedIndex = 0;
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

        private void Cerrar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
          
            dtgvPaciente.DataSource = ClienteDAL.BuscarClientes(txtBuscar.Text);
           
        }

        private void btnActu2_Click(object sender, EventArgs e)
        {

            Cliente pCliente = new Cliente();
            pCliente.Apellido = txtApellido.Text;
            pCliente.Nombre = txtNombre.Text;
            pCliente.Edad = Convert.ToInt64(txtEdad.Text);
            pCliente.Fecha = dtpFecha.Value.ToShortDateString();
            pCliente.Domicilio = txtDomi.Text;
            pCliente.Tel = txtTel.Text;
            pCliente.Cel = txtCel.Text;
            pCliente.Correo = txtCorreo.Text;
            pCliente.Id = ClienteActual.Id;


            int resultado = ClienteDAL.Modificar(pCliente);

            if (resultado > 0)
            {

                MessageBox.Show("Paciente Modificado Correctamente", "Paciente Modificado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                limpiar();
                btnActu2.Enabled = false;
                btnGuardar.Enabled = true;
                txtBuscar.Text = "";
                dtgvPaciente.DataSource = ClienteDAL.BuscarClientes(txtBuscar.Text);
            }

            else
            {
                MessageBox.Show("No se pudo Modificar el Paciente", "Error!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }




        }

       

       

   }
}


     

  
  

