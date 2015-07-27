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
using System.Reflection;
using System.IO;


namespace App1.Forms
{
    public partial class frmMenuPrincipal : MetroForm
    {
        
        public frmMenuPrincipal()
        {
            InitializeComponent();
            
           
        }

   
        private void cargarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmCargarCliente CargarClienteForm = new frmCargarCliente();
            CargarClienteForm.MdiParent = this;
            CargarClienteForm.Show();

        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarTratamiento CargarTratamiento = new frmCargarTratamiento();
            CargarTratamiento.MdiParent = this;
            CargarTratamiento.Show();
        }

       

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
              DialogResult Mensaje = MessageBox.Show("¿Seguro que Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( Mensaje == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }

          
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
            Turnos PruebaForm = new Turnos();
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

          
            lblUsuario.Text = Program.usuario;
            Tiempo.Enabled = true;
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

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtTerapeuta_Click(object sender, EventArgs e)
        {

        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string resourcePath =  "ManuaUsuariol.chm";                  
           
            resourcePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            resourcePath += "\\Resources\\ManuaUsuariol.chm";
            if (resourcePath == null)
            throw new FileNotFoundException("Resource not found");

            Help.ShowHelp(this, resourcePath);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe ace = new frmAcercaDe();
            ace.MdiParent = this;
            ace.Show();

        }

       


    

     

      
        private void tratamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmTratamiento2 trata = new frmAdmTratamiento2();
            trata.MdiParent = this;
            trata.Show();
        }

        private void informesTerapeutaYPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformes t = new frmInformes();
            t.MdiParent = this;
            t.Show();
        }

  

        private void gastosEnProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformes2 tf = new frmInformes2();
            tf.MdiParent = this;
            tf.Show();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
             DialogResult Mensaje = MessageBox.Show("¿Seguro que Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( Mensaje == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }

          
        }
        

     

 
      




       
    }
}
