using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App1.Clases;
using App1.Clases.AccesoSQL;
using MetroFramework.Forms;

namespace App1.Forms
{
    public partial class frmTerapeuta : MetroForm
    {
        private Agenda pAgenda;
        private Agenda AgendaActual { get; set; }


        public frmTerapeuta()
        {
            InitializeComponent();

        }



        private void frmTerapeuta_Load(object sender, EventArgs e)
        {

            cboTerapeuta.DataSource = TerapeutaDAL.ObtenerTerapeuta();
            cboTerapeuta.DisplayMember = "Apellido";
            cboTerapeuta.ValueMember = "Id";
            cboJornada.DataSource = TerapeutaDAL.ObtenerJornadas();
            cboJornada.DisplayMember = "tipo_Jornada";
            cboJornada.ValueMember = "Id";
            cboEspecialidad.DataSource = TerapeutaDAL.ObtenerEspecialidad();
            cboEspecialidad.DisplayMember = "descripcion";
            cboEspecialidad.ValueMember = "Id";
            cboTerapeutaNOLAb.DataSource = TerapeutaDAL.ObtenerTerapeuta();
            cboTerapeutaNOLAb.DisplayMember = "Apellido";
            cboTerapeutaNOLAb.ValueMember = "Id";

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Terapeuta Terapeutas = new Terapeuta();
            if (validar())
            {
                Terapeutas.Apellido = txtApe.Text;
                Terapeutas.Nombre = txtNom.Text;
                Terapeutas.Usuario = txtUsu.Text;
                Terapeutas.Contraseña = txtContra.Text;
                Terapeutas.Id_Jornada = (int) cboJornada.SelectedValue;
                Terapeutas.Id_Especialidad = (int) cboEspecialidad.SelectedValue;

                int resultado = TerapeutaDAL.AgregarTerapeuta(Terapeutas);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Ingresados Correctamente", "Datos Guardados", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                 
                    cboTerapeuta.DataSource = TerapeutaDAL.ObtenerTerapeuta();
                    cboTerapeuta.DisplayMember = "Apellido";
                    cboTerapeuta.ValueMember = "Id";
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

        private void btnCargarL_Click_1(object sender, EventArgs e)
        {

            if (!AgendaDAL.Existe(Convert.ToInt32(cboTerapeuta.SelectedValue)))
            {
                Agenda pAgenda = new Agenda();
                {
                    pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;
                    if (chbLunes.Checked)
                    {
                        pAgenda.Lunes = true;
                        pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;

                    }

                    if (chbMartes1.Checked)
                    {
                        pAgenda.Martes = true;
                        pAgenda.IdTerapeuta = (Int64)cboTerapeuta.SelectedValue;


                    }
                    if (chbMiercoles.Checked)
                    {
                        pAgenda.Miercoles = true;
                        pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;

                    }

                    if (chbJueves.Checked)
                    {
                        pAgenda.Jueves = true;
                        pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;


                    }
                    if (chbViernes.Checked)
                    {
                        pAgenda.Viernes = true;
                        pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;

                    }
                    if (chbSabado.Checked)
                    {
                        pAgenda.Sabado = true;
                        pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;

                    }
                    if (chbDomingo.Checked)
                    {
                        pAgenda.Domingo = true;
                        pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;

                    }
                    AgendaDAL.AgregarDia(pAgenda);
                    MessageBox.Show("Se agrego el DIA", "Dias Guardados", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }

            }
            else
            {MessageBox.Show("Ya Se han Asiganado los dias al Terapeuta!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            

        }

        private void cboTerapeuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Agenda pAgenda = new Agenda();

            if (cboTerapeuta.SelectedValue != null)
            {
                pAgenda = AgendaDAL.ObtenerAgenda(((Terapeuta) cboTerapeuta.SelectedItem).Id);


              

                if (pAgenda.Lunes){chbLunes.Checked = true;}
                else{chbLunes.Checked = false;}

                if (pAgenda.Martes) { chbMartes1.Checked = true; }
                else { chbMartes1.Checked = false; }

                if (pAgenda.Miercoles){chbMiercoles.Checked = true;}
                else{chbMiercoles.Checked = false;}

                if (pAgenda.Jueves){chbJueves.Checked = true;
                }else{chbJueves.Checked = false;}

                if (pAgenda.Viernes){chbViernes.Checked = true;}
                else{chbViernes.Checked = false;}

                if (pAgenda.Sabado){chbSabado.Checked = true;}
                else{chbSabado.Checked = false;}

                if (pAgenda.Domingo){chbDomingo.Checked = true;}
                else{chbDomingo.Checked = false;}
              }
            
        }

        private void btnModLab_Click(object sender, EventArgs e)
        {
             if (cboTerapeuta.SelectedValue !=null)
            {
                Int64 Id = Convert.ToInt64(cboTerapeuta.SelectedValue);
                AgendaActual = AgendaDAL.ObtenerAgenda(Id);

            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Terapeuta");
            }

            Agenda pAgenda = new Agenda();
            {
                pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;
                if (chbLunes.Checked)
                {
                    pAgenda.Lunes = true;
                    pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;

                }
                if (chbMartes1.Checked)
                {
                    pAgenda.Martes = true;
                    pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;

                }
                if (chbMiercoles.Checked)
                {
                    pAgenda.Miercoles = true;
                    pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;

                }

                if (chbJueves.Checked)
                {
                    pAgenda.Jueves = true;
                    pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;


                }
                if (chbViernes.Checked)
                {
                    pAgenda.Viernes = true;
                    pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;

                }
                if (chbSabado.Checked)
                {
                    pAgenda.Sabado = true;
                    pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;

                }
                if (chbDomingo.Checked)
                {
                    pAgenda.Domingo = true;
                    pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;

                }

                pAgenda.IdTerapeuta = pAgenda.IdTerapeuta;
                
                int resultado = AgendaDAL.ModificarAgenda(pAgenda);

                if (resultado > 0)
                {
                    MessageBox.Show("Agenda Modificado con exito", "Agenda Modificada", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("No se pudo Modificar La Agenda", "Ocurrio un error!!", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }

            }


        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarNL_Click(object sender, EventArgs e)
        {

             if (!AgendaDAL.DiaLaboralExiste( Convert.ToInt32(cboTerapeutaNOLAb.SelectedValue),dtDiasNoLaborables.Value.ToShortDateString()))
            {
                DiasNoLaborales DiasNoLab = new DiasNoLaborales();
                {

                    Convert.ToInt32(cboTerapeutaNOLAb.SelectedValue);
                    DiasNoLab.DiaNoLaboral = dtDiasNoLaborables.Value.ToShortDateString();
                    DiasNoLab.IdTerapeuta = (Int64) cboTerapeutaNOLAb.SelectedValue;

                }
                AgendaDAL.AgregarDiaNoLaboral(DiasNoLab);
                MessageBox.Show("Se agrego el Dia!!!! ", "Dia No Laboral Guardado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
             else
             {
                 MessageBox.Show("Ya Se Asigno el Dia laboral Al Terapeuta!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
             }


        }
    }
      

    }


