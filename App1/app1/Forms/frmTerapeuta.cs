using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App1.Clases;
using MetroFramework.Forms;

namespace App1.Forms
{
    public partial class frmTerapeuta : MetroForm
    {
        public frmTerapeuta()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAgenda agenda=new frmAgenda();
            agenda.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Terapeuta Terapeutas  = new Terapeuta();
            if (validar())
            {
                Terapeutas.Apellido = txtApe.Text;
                Terapeutas.Nombre = txtNom.Text;
                Terapeutas.Usuario = txtUsu.Text;
                Terapeutas.Contraseña = txtContra.Text;
               
             
               

                int resultado = ConsultorioDAL.AgregarTerapeuta(Terapeutas);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Ingresados Correctamente", "Datos Guardados", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar", "Error al Guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }

        }


        private bool validar()
        {
            if (txtApe.Text == "")
            {
                MessageBox.Show("Debe ingresar Apellido...");
                txtApe.Focus();
                return false;
            }
            if (txtNom.Text == "")
            {
                MessageBox.Show("Debe ingresar Nombre...");
                txtApe.Focus();
                return false;
            }


            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        }


    
    }

