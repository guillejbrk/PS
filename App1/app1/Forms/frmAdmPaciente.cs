using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App1.Clases;
using App1.Clases.AccesoSQL;
using MetroFramework.Forms;

namespace App1.Forms
{
    public partial class frmAdmPaciente : MetroForm
    {
        public frmAdmPaciente()
        {
            InitializeComponent();
        }           
       


        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCargarCliente CargarClienteForm = new frmCargarCliente();
            
            CargarClienteForm.Show();
            this.Close();

            
        }

     

        private void txtBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            dtgPac.DataSource = ClienteDAL.BuscarClientes2(txtBuscar.Text);
        }

      
      

       

        
      
    }
}
