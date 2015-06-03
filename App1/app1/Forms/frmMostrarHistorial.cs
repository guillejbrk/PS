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
            txtObservacion.Text = "";
        }

        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cboFecha.DataSource = HistoriaDAL.ObtenerFecha(((Cliente)cboPaciente.SelectedItem).Id);
            cboFecha.DisplayMember = "Fecha";
                 txtObservacion.Text = "";
        }

        private void cboFecha_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtObservacion.Text = ((Historias)cboFecha.SelectedItem).Observacion;

         
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  


    }
}
