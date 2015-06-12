using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App1.Forms
{
    public partial class frmLog : Form
    {
       public frmLog()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            {

    if ((txtUsuario.Text == "" || txtPass.Text == ""))
            {
                MessageBox.Show("Todos Los Campos Deben ser Completados.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUsuario.Focus();
                txtPass.Clear();
                txtUsuario.Clear();
            }
            else
            {                             
                SqlConnection Conn = BDComun.obtenerConexion();
         
                SqlCommand Consultar =
                    new SqlCommand(
                        "select usuario, contraseña from Terapeuta where  usuario = '" + txtUsuario.Text +
                        "'and Contraseña = '" + this.txtPass.Text + "'", Conn);
                SqlDataReader Ejecuta = Consultar.ExecuteReader();
                if (Ejecuta.Read() == true)
                {
                    MessageBox.Show("Bienvenido " + txtUsuario.Text, "  ", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Program.usuario = txtUsuario.Text;
                    this.Hide();
                    frmMenuPrincipal MenuPrincipal = new frmMenuPrincipal();
                    MenuPrincipal.Show();

                }
                else
                {
                    MessageBox.Show("Error al Verificar los Datos.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtPass.Clear();
                    txtUsuario.Clear();
                      Conn.Close();
                }


            }

        }
            
        }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if ((txtUsuario.Text == "" || txtPass.Text == ""))
                {
                    MessageBox.Show("Todos Los Campos Deben ser Completados.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtPass.Clear();
                    txtUsuario.Clear();
                }
                else
                {

                    SqlConnection Conn = BDComun.obtenerConexion();
                  
                    SqlCommand Consultar =
                        new SqlCommand(
                            "select usuario, contraseña from Terapeuta where  usuario = '" + txtUsuario.Text +
                            "'and Contraseña = '" + this.txtPass.Text + "'", Conn);
                    SqlDataReader Ejecuta = Consultar.ExecuteReader();
                    if (Ejecuta.Read() == true)
                    {
                        MessageBox.Show("Bienvenido " + txtUsuario.Text, "  ", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Program.usuario = txtUsuario.Text;
                        this.Hide();
                        frmMenuPrincipal MenuPrincipal = new frmMenuPrincipal();
                        MenuPrincipal.Show();

                    }
                    else
                    {
                        MessageBox.Show("Error al Verificar los Datos.", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        txtPass.Clear();
                        txtUsuario.Clear();
                        Conn.Close();
                    }




                }

            }

        }

            
    }
}
