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
    public partial class frmMostrarHistorial : MetroForm
    {
        public frmMostrarHistorial()
        {
            InitializeComponent();
        }

        private void frmMostrarHistorial_Load(object sender, EventArgs e)
        {
            cboPaciente.DataSource = HistoriaDAL.ObtenerClientes();
            cboPaciente.DisplayMember = "Apellido";
            cboPaciente.ValueMember = "Id";
        }

        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cboFecha.DataSource = HistoriaDAL.ObtenerFecha(((Cliente)cboPaciente.SelectedItem).Id);
            cboFecha.DisplayMember = "Fecha";
        }

        private void cboFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int64 Id = Convert.ToInt64(cboPaciente.SelectedValue);
            HistoriaDAL.ObtenerObservacion(Id, cboFecha.ToString());
             

        }

  


    }
}
