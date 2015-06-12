using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using App1.Clases.AccesoSQL;

namespace App1.Forms
{
    public partial class frmAgendaTel : MetroForm
    {
        public frmAgendaTel()
        {
            InitializeComponent();
        }

        private void frmAgendaTel_Load(object sender, EventArgs e)
        {
         
         
        }

        private void txtPaciente_KeyUp(object sender, KeyEventArgs e)
        {
            dgvTele.DataSource = null;
            dgvTele.DataSource = ClienteDAL.BuscarClientes2(txtPaciente.Text);
            dgvTele.Columns["id"].Visible = false;
            dgvTele.Columns["Edad"].Visible = false;
            dgvTele.Columns["Fecha"].Visible = false;
            dgvTele.Columns["Correo"].Visible = false;
            dgvTele.Columns["Domicilio"].Visible = false;
         
           
        }

        private void dgvTele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPaciente_Click(object sender, EventArgs e)
        {

        }
    }
}
