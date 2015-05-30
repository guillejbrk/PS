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

    

    public partial class frmAgenda : MetroForm
    {
        private Agenda AgendaActual { get; set; }
       
        public frmAgenda()
        {

            InitializeComponent();

        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            cbmTera.DataSource = TerapeutaDAL.ObtenerTerapeuta();
            cbmTera.DisplayMember = "Apellido";
            cbmTera.ValueMember = "Id";
        }
        private void cbmTera_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();
            Agenda pAgenda = new Agenda();


            if (cbmTera.SelectedValue != null)
            {


                pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesAño(((Terapeuta)cbmTera.SelectedItem).Id);
                lstNoLaboralesSemana.DataSource = null;
                lstNoLaboralesSemana.DataSource = pDiasNoLaborales;
                cbmTera.ValueMember = "Id";
                lstNoLaboralesSemana.DisplayMember = "DiaNoLaboral";

                rbtSemana.Checked = false;
                rbtMes.Checked = false;
                rbtAño.Checked = false;


                pAgenda = AgendaDAL.ObtenerAgenda(((Terapeuta)cbmTera.SelectedItem).Id);
                
                if (pAgenda.Lunes)
                {
                    chbLunes1.Checked = true;
                }
                else
                {
                    chbLunes1.Checked = false;
                }

                if (pAgenda.Martes)
                {
                    chbMartes2.Checked = true;
                }
                else
                {
                    chbMartes2.Checked = false;
                }

                if (pAgenda.Miercoles)
                {
                    chbMiercoles3.Checked = true;
                }
                else
                {
                    chbMiercoles3.Checked = false;
                }

                if (pAgenda.Jueves)
                {
                    chbJueves4.Checked = true;
                }
                else
                {
                    chbJueves4.Checked = false;
                }

                if (pAgenda.Viernes)
                {
                    chbViernes5.Checked = true;
                }
                else
                {
                    chbViernes5.Checked = false;
                }

                if (pAgenda.Sabado)
                {
                    chbSabado6.Checked = true;
                }
                else
                {
                    chbSabado6.Checked = false;
                }

                if (pAgenda.Domingo)
                {
                    chbDomingo7.Checked = true;
                }
                else
                {
                    chbDomingo7.Checked = false;
                }
            }

        }

        private void btnCargarL_Click(object sender, EventArgs e)
        {
            {
                if (!AgendaDAL.Existe(Convert.ToInt32(cbmTera.SelectedValue)))
                {
                    Agenda pAgenda = new Agenda();
                    {
                        pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;
                        if (chbLunes1.Checked)
                        {
                            pAgenda.Lunes = true;
                            pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;
                        }
                        if (chbMartes2.Checked)
                        {
                            pAgenda.Martes = true;
                            pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;
                        }
                        if (chbMiercoles3.Checked)
                        {
                            pAgenda.Miercoles = true;
                            pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;

                        }
                        if (chbJueves4.Checked)
                        {
                            pAgenda.Jueves = true;
                            pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;
                        }
                        if (chbViernes5.Checked)
                        {
                            pAgenda.Viernes = true;
                            pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;

                        }
                        if (chbSabado6.Checked)
                        {
                            pAgenda.Sabado = true;
                            pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;
                        }
                        if (chbDomingo7.Checked)
                        {
                            pAgenda.Domingo = true;
                            pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;
                        }

                        AgendaDAL.AgregarDia(pAgenda);
                        MessageBox.Show("Se agrego el DIA", "Dias Guardados", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Ya Se han Asiganado los dias al Terapeuta!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }



            }
        }

        private void btnModLab_Click(object sender, EventArgs e)
        {
            if (cbmTera.SelectedValue != null)
            {
                Int64 Id = Convert.ToInt64(cbmTera.SelectedValue);
                AgendaActual = AgendaDAL.ObtenerAgenda(Id);

            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Terapeuta");
            }

            Agenda pAgenda = new Agenda();
            {
                pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;
                if (chbLunes1.Checked)
                {
                    pAgenda.Lunes = true;
                    pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;

                }
                if (chbMartes2.Checked)
                {
                    pAgenda.Martes = true;
                    pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;

                }
                if (chbMiercoles3.Checked)
                {
                    pAgenda.Miercoles = true;
                    pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;

                }

                if (chbJueves4.Checked)
                {
                    pAgenda.Jueves = true;
                    pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;


                }
                if (chbViernes5.Checked)
                {
                    pAgenda.Viernes = true;
                    pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;

                }
                if (chbSabado6.Checked)
                {
                    pAgenda.Sabado = true;
                    pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;

                }
                if (chbDomingo7.Checked)
                {
                    pAgenda.Domingo = true;
                    pAgenda.IdTerapeuta = (Int64)cbmTera.SelectedValue;

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

        private void btnCargarNL_Click(object sender, EventArgs e)
        {
            if (!AgendaDAL.DiaLaboralExiste(Convert.ToInt32(cbmTera.SelectedValue),
             dtDiasNoLaborables.Value.ToShortDateString()))
            {
                if (dtDiasNoLaborables.Value >= DateTime.Today)
                {

                    DiasNoLaborales diasNoLab = new DiasNoLaborales();


                    diasNoLab.DiaNoLaboral = dtDiasNoLaborables.Value.ToShortDateString();
                    diasNoLab.IdTerapeuta = (Int64)cbmTera.SelectedValue;


                    AgendaDAL.AgregarDiaNoLaboral(diasNoLab);
                    MessageBox.Show("Se Cargo Dia No Laboral", "Dia No Laboral", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);



                    List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();
                    pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesAño(((Terapeuta)cbmTera.SelectedItem).Id);
                    lstNoLaboralesSemana.DataSource = null;
                    lstNoLaboralesSemana.DataSource = pDiasNoLaborales;
                    cbmTera.ValueMember = "Id";
                    lstNoLaboralesSemana.DisplayMember = "DiaNoLaboral";

                   
                        rbtSemana.Checked = false;
                        rbtMes.Checked = false;
                        rbtAño.Checked = false;
                }


                else
                {
                    MessageBox.Show("Fecha No permitida!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Ya se Cargo es Dia No LAboral para ese Terapeuta!!", "Error", MessageBoxButtons.OK,

                    MessageBoxIcon.Error);
            }

        }

        private void rbtSemana_CheckedChanged_1(object sender, EventArgs e)
        {
            List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();

            pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesSemana(((Terapeuta)cbmTera.SelectedItem).Id);

            lstNoLaboralesSemana.DataSource = pDiasNoLaborales;
            cbmTera.ValueMember = "Id";
            lstNoLaboralesSemana.DisplayMember = "DiaNoLaboral";



        }

        private void rbtMes_CheckedChanged_1(object sender, EventArgs e)
        {
            List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();
            pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesMes(((Terapeuta)cbmTera.SelectedItem).Id);

            lstNoLaboralesSemana.DataSource = pDiasNoLaborales;
            cbmTera.ValueMember = "Id";
            lstNoLaboralesSemana.DisplayMember = "DiaNoLaboral";
        }

        private void rbtAño_CheckedChanged_1(object sender, EventArgs e)
        {
            List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();
            pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesAño(((Terapeuta)cbmTera.SelectedItem).Id);

            lstNoLaboralesSemana.DataSource = pDiasNoLaborales;
            cbmTera.ValueMember = "Id";
            lstNoLaboralesSemana.DisplayMember = "DiaNoLaboral";
        }

        private void btnEliminarDiaNoLaboral_Click_1(object sender, EventArgs e)
        {


            Int64 Id = Convert.ToInt64(cbmTera.SelectedValue);

            AgendaDAL.EliminarDiaNoLaboral(Id, (lstNoLaboralesSemana.Text));

            MessageBox.Show("Dia No Laboral Eliminado", "Agenda Modificada", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


            List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();

            lstNoLaboralesSemana.DataSource = null;
            lstNoLaboralesSemana.DataSource = pDiasNoLaborales;
            cbmTera.ValueMember = "Id";
            lstNoLaboralesSemana.DisplayMember = "DiaNoLaboral";


            rbtSemana.Checked = false;
            rbtMes.Checked = false;
            rbtAño.Checked = false;
        }

       

        

        }
    }

