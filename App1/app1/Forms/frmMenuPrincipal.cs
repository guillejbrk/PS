using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;


namespace App1.Forms
{
    public partial class frmMenuPrincipal : MetroForm
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
          timer1.Enabled=true;
           
        }

   
        private void cargarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmCargarCliente CargarClienteForm = new frmCargarCliente();
            CargarClienteForm.MdiParent = this;
            CargarClienteForm.Show();

        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmTratamiento CargarTratamiento = new frmAdmTratamiento();
            CargarTratamiento.MdiParent = this;
            CargarTratamiento.Show();
        }

       

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void cargarHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial CargarTratamiento = new frmHistorial();
            CargarTratamiento.MdiParent = this;
            CargarTratamiento.Show();
        }

        private void cargarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarTurno CargarTurno = new frmCargarTurno();
            CargarTurno.MdiParent = this;
            CargarTurno.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCargarCliente CargarClienteForm = new frmCargarCliente();
            CargarClienteForm.MdiParent = this;
            CargarClienteForm.Show();
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrueba PruebaForm = new frmPrueba();
            PruebaForm.MdiParent = this;
            PruebaForm.Show();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos frmProductos = new frmProductos();
            frmProductos.MdiParent = this;
            frmProductos.Show();
        }

        private void terapeutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTerapeuta frmTerapeuta = new frmTerapeuta();
            frmTerapeuta.MdiParent = this;
            frmTerapeuta.Show();

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdmPaciente frmPaciente= new frmAdmPaciente();
            frmPaciente.MdiParent = this;
            frmPaciente.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda frmAgenda = new frmAgenda();
            frmAgenda.MdiParent = this;
            frmAgenda.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void nuevaHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial CargarTratamiento = new frmHistorial();
            CargarTratamiento.MdiParent = this;
            CargarTratamiento.Show();
        }

        private void prodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductosDisponibles ProductosDisponibles = new frmProductosDisponibles();
            ProductosDisponibles.MdiParent = this;
            ProductosDisponibles.Show();
        }

        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmPaciente Pacientes = new frmAdmPaciente();
            Pacientes.MdiParent = this;
            Pacientes.Show();
        }

        private void buscarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarHistorial Histo = new frmMostrarHistorial();
            Histo.MdiParent = this;
            Histo.Show();
        }

        private void agendaTelefonicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgendaTel Age = new frmAgendaTel();
            Age.MdiParent = this;
            Age.Show();
        }





       
    }
}
