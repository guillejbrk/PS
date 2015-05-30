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
using App1.Clases;

namespace App1.Forms
{
    public partial class frmProductosDisponibles : MetroForm
    {
        public frmProductosDisponibles()
        {
            InitializeComponent();
        }

        private void frmProductosDisponibles_Load(object sender, EventArgs e)
        {
            cboTerapeuta.DataSource = TerapeutaDAL.ObtenerTerapeuta();
            cboTerapeuta.DisplayMember = "Apellido";
            cboTerapeuta.ValueMember = "Id";

        }

        private void cboTerapeuta_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvProductos.DataSource = ProductosDAL.ObtenerProductoss(((Terapeuta)cboTerapeuta.SelectedItem).Id);
            dgvProductos.Columns["id_Terapeuta"].Visible = false;

        }

       
    }
}
