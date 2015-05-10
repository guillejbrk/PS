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

                    SqlConnection conexion =
                        new SqlConnection(
                            @"data source=KRUSCHOV\SQLEXPRESS; initial catalog=P7; user Id=sa; Password=guille");
                    conexion.Open();
                    SqlCommand Consultar =
                        new SqlCommand(
                            "select usuario, contraseña from Terapeuta where  usuario = '" + txtUsuario.Text +
                            "'and Contraseña = '" + this.txtPass.Text + "'", conexion);
                    SqlDataReader Ejecuta = Consultar.ExecuteReader();
                    if (Ejecuta.Read() == true)
                    {
                        MessageBox.Show("Bienvenido " + txtUsuario.Text, "  ", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
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
                        conexion.Close();
                    }




                }
            }
        }
    }
}
