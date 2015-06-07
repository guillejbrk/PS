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
       
        private Agenda AgendaActual { get; set; }
        public Terapeuta TerapeutaSeleccionado { get; set; }
        public Terapeuta TerapeutaActual { get; set; }

        public frmTerapeuta()
        {
            InitializeComponent();

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
           




        private void frmTerapeuta_Load(object sender, EventArgs e)
        {


            cboTerapeuta.DataSource = TerapeutaDAL.ObtenerTerapeuta();
            cboTerapeuta.DisplayMember = "Apellido";
            cboTerapeuta.ValueMember = "Id";
           cboJornada.DataSource = TerapeutaDAL.ObtenerJornada();
            cboJornada.DisplayMember = "tipo_Jornada";
            cboJornada.ValueMember = "Id";
            cboEspecialidad.DataSource = TerapeutaDAL.ObtenerEspecialidad();
            cboEspecialidad.DisplayMember = "descripcion";
            cboEspecialidad.ValueMember = "Id";

            dtgvTerapeuta.DataSource = TerapeutaDAL.ObtenerTerapeutaParaDTGV();
            btnUpdate.Enabled = false;

        }

        private bool validar()
        {
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar Apellido...");
                txtApellido.Focus();
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar Nombre...");
                txtNombre.Focus();
                return false;
            }
            if (txtPass.Text != txtPass2.Text)
            {
                MessageBox.Show("Verificar Contraseña...");
                txtApellido.Focus();
                return false;
            }


            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Terapeuta Terapeutas = new Terapeuta();
            if (validar())
            {
                Terapeutas.Apellido = txtApellido.Text;
                Terapeutas.Nombre = txtNombre.Text;
                Terapeutas.Usuario = txtUsuario.Text;
                Terapeutas.Contraseña = txtPass.Text;
                Terapeutas.Id_Jornada = (int)cboJornada.SelectedValue;
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
                        pAgenda.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;
                    }
                    if (chbMiercoles.Checked)
                    {
                        pAgenda.Miércoles = true;
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
                    btnModLab.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Ya Se han Asiganado los dias al Terapeuta!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }



        }

        private void cboTerapeuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();
            Agenda pAgenda = new Agenda();

            if (cboTerapeuta.SelectedValue != null)
            {
                pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesAño(((Terapeuta)cboTerapeuta.SelectedItem).Id);
                lstNoLaboralesSemana.DataSource = null;
                lstNoLaboralesSemana.DataSource = pDiasNoLaborales;
                cboTerapeuta.ValueMember = "Id";
                lstNoLaboralesSemana.DisplayMember = "DiaNoLaboral";

                rbtSemana.Checked = false;
                rbtMes.Checked = false;
                rbtAño.Checked = false;



                pAgenda = AgendaDAL.ObtenerAgenda(((Terapeuta) cboTerapeuta.SelectedItem).Id);
                

                if (pAgenda.Lunes)
                {
                    chbLunes.Checked = true;
                }
                else
                {
                    chbLunes.Checked = false;
                }

                if (pAgenda.Martes)
                {
                    chbMartes1.Checked = true;
                }
                else
                {
                    chbMartes1.Checked = false;
                }

                if (pAgenda.Miércoles)
                {
                    chbMiercoles.Checked = true;
                }
                else
                {
                    chbMiercoles.Checked = false;
                }

                if (pAgenda.Jueves)
                {
                    chbJueves.Checked = true;
                }
                else
                {
                    chbJueves.Checked = false;
                }

                if (pAgenda.Viernes)
                {
                    chbViernes.Checked = true;
                }
                else
                {
                    chbViernes.Checked = false;
                }

                if (pAgenda.Sabado)
                {
                    chbSabado.Checked = true;
                }
                else
                {
                    chbSabado.Checked = false;
                }

                if (pAgenda.Domingo)
                {
                    chbDomingo.Checked = true;
                }
                else
                {
                    chbDomingo.Checked = false;
                }
            }

        }

        private void btnModLab_Click(object sender, EventArgs e)
        {
            if (cboTerapeuta.SelectedValue != null)
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
                    pAgenda.Miércoles = true;
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

        private void btnCargarNL_Click(object sender, EventArgs e)
        {

            if (!AgendaDAL.DiaLaboralExiste(Convert.ToInt32(cboTerapeuta.SelectedValue),
                dtDiasNoLaborables.Value.ToShortDateString()))
            {
                if (dtDiasNoLaborables.Value >= DateTime.Today)
                {

                    DiasNoLaborales diasNoLab = new DiasNoLaborales();


                    diasNoLab.DiaNoLaboral = dtDiasNoLaborables.Value.ToShortDateString();
                    diasNoLab.IdTerapeuta = (Int64) cboTerapeuta.SelectedValue;


                    AgendaDAL.AgregarDiaNoLaboral(diasNoLab);
                    MessageBox.Show("Se Cargo Dia No Laboral", "Dia No Laboral", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                  

                    List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();
                    pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesAño(((Terapeuta)cboTerapeuta.SelectedItem).Id);
                    lstNoLaboralesSemana.DataSource = null;
                    lstNoLaboralesSemana.DataSource = pDiasNoLaborales;

                    cboTerapeuta.ValueMember = "Id";
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

        private void rbtSemana_CheckedChanged(object sender, EventArgs e)
        {
          //  this.cboTerapeuta.SelectedIndexChanged += new System.EventHandler(this.rbtSemana_CheckedChanged);
            List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();

            pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesSemana(((Terapeuta) cboTerapeuta.SelectedItem).Id);

            lstNoLaboralesSemana.DataSource = pDiasNoLaborales;
            cboTerapeuta.ValueMember = "Id";
            lstNoLaboralesSemana.DisplayMember = "DiaNoLaboral";
        }

        private void rbtMes_CheckedChanged(object sender, EventArgs e)
        {
          //  this.cboTerapeuta.SelectedIndexChanged += new System.EventHandler(this.rbtMes_CheckedChanged);
            List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();
            pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesMes(((Terapeuta) cboTerapeuta.SelectedItem).Id);

            lstNoLaboralesSemana.DataSource = pDiasNoLaborales;
            cboTerapeuta.ValueMember = "Id";
            lstNoLaboralesSemana.DisplayMember = "DiaNoLaboral";

        }

        private void rbtAño_CheckedChanged(object sender, EventArgs e)
        {
           // this.cboTerapeuta.SelectedIndexChanged += new System.EventHandler(this.rbtAño_CheckedChanged);

            List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();
            pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesAño(((Terapeuta) cboTerapeuta.SelectedItem).Id);

            lstNoLaboralesSemana.DataSource = pDiasNoLaborales;
            cboTerapeuta.ValueMember = "Id";
            lstNoLaboralesSemana.DisplayMember = "DiaNoLaboral";
        }

        private void btnEliminarDiaNoLaboral_Click(object sender, EventArgs e)
        {
                Int64 Id = Convert.ToInt64(cboTerapeuta.SelectedValue);

                AgendaDAL.EliminarDiaNoLaboral(Id, (lstNoLaboralesSemana.Text));

                MessageBox.Show("Dia No Laboral Eliminado", "Agenda Modificada", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

           
                List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();

                lstNoLaboralesSemana.DataSource = null;
                lstNoLaboralesSemana.DataSource = pDiasNoLaborales;
                cboTerapeuta.ValueMember = "Id";
                lstNoLaboralesSemana.DisplayMember = "DiaNoLaboral";

            rbtSemana.Checked = false;
            rbtMes.Checked = false;
            rbtAño.Checked = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            if (AgendaDAL.Existe(Convert.ToInt32(cboTerapeuta.SelectedValue)))
            {
                Int64 Id = Convert.ToInt64(cboTerapeuta.SelectedValue);

                AgendaDAL.EliminarAgenda(Id);

                    MessageBox.Show("Agenda Eliminada", "Agenda", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                btnModLab.Enabled = false;

                Agenda pAgenda = new Agenda();
                pAgenda = AgendaDAL.ObtenerAgenda(((Terapeuta)cboTerapeuta.SelectedItem).Id);

                if (pAgenda.Lunes)
                {
                    chbLunes.Checked = true;
                }
                else
                {
                    chbLunes.Checked = false;
                }

                if (pAgenda.Martes)
                {
                    chbMartes1.Checked = true;
                }
                else
                {
                    chbMartes1.Checked = false;
                }

                if (pAgenda.Miércoles)
                {


                    chbMiercoles.Checked = true;
                }
                else
                {
                    chbMiercoles.Checked = false;
                }

                if (pAgenda.Jueves)
                {

                    chbJueves.Checked = true;
                }
                else
                {
                    chbJueves.Checked = false;
                }

                if (pAgenda.Viernes)
                {
                    chbViernes.Checked = true;
                }
                else
                {
                    chbViernes.Checked = false;
                }

                if (pAgenda.Sabado)
                {

                    chbSabado.Checked = true;
                }
                else
                {
                    chbSabado.Checked = false;
                }

                if (pAgenda.Domingo)
                {

                    chbDomingo.Checked = true;
                }
                else
                {
                    chbDomingo.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("No Existe Agenda a Eliminar", "Agenda", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnNuevosTurnos_Click(object sender, EventArgs e)
        {
            //Agregar Condicion para que no se generen dos veces los mismos dias!
            TurnosDAL.GenerarTurnos(((Terapeuta)cboTerapeuta.SelectedItem).Id);
          
        }

        private void btnCargarNoLab_Click(object sender, EventArgs e)
        {

            if (!AgendaDAL.DiaLaboralExiste(Convert.ToInt32(cboTerapeuta.SelectedValue),
                dtDiasNoLaborables.Value.ToShortDateString()))
            {
                if (dtDiasNoLaborables.Value >= DateTime.Today)
                {

                    DiasNoLaborales diasNoLab = new DiasNoLaborales();


                    diasNoLab.DiaNoLaboral = dtDiasNoLaborables.Value.ToShortDateString();
                    diasNoLab.IdTerapeuta = (Int64)cboTerapeuta.SelectedValue;


                    AgendaDAL.AgregarDiaNoLaboral(diasNoLab);
                    MessageBox.Show("Se Cargo Dia No Laboral", "Dia No Laboral", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);



                    List<DiasNoLaborales> pDiasNoLaborales = new List<DiasNoLaborales>();
                    pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesAño(((Terapeuta)cboTerapeuta.SelectedItem).Id);
                    lstNoLaboralesSemana.DataSource = null;
                    lstNoLaboralesSemana.DataSource = pDiasNoLaborales;

                    cboTerapeuta.ValueMember = "Id";
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgvTerapeuta.SelectedRows.Count == 1)
            {
                Int64 Id = Convert.ToInt64(dtgvTerapeuta.CurrentRow.Cells[0].Value);
                TerapeutaSeleccionado = TerapeutaDAL.ObtenerTerapeuta2(Id);

            }
            else
            {
                MessageBox.Show("Seleccione Paciente que desea Modificar", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            if (TerapeutaSeleccionado != null)
            {
                TerapeutaActual = TerapeutaSeleccionado;

                txtApellido.Text = TerapeutaSeleccionado.Apellido;
                txtNombre.Text = TerapeutaSeleccionado.Nombre;
                txtUsuario.Text = TerapeutaSeleccionado.Usuario;
                txtPass.Text = TerapeutaSeleccionado.Contraseña;
                txtPass2.Text = TerapeutaSeleccionado.Contraseña;  
                cboJornada.SelectedValue = TerapeutaSeleccionado.Id_Jornada;
                cboEspecialidad.SelectedValue = TerapeutaSeleccionado.Id_Especialidad;
                sdf.SelectedIndex = 0;
                btnUpdate.Enabled = true;
             
               

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Terapeuta pTerapeuta = new Terapeuta();
            pTerapeuta.Apellido = txtApellido.Text;
            pTerapeuta.Nombre = txtNombre.Text;
            pTerapeuta.Usuario= txtUsuario.Text;
            pTerapeuta.Contraseña = txtPass.Text;
            pTerapeuta.Id_Jornada = (int)cboJornada.SelectedValue; ;
            pTerapeuta.Id_Especialidad = (int)cboEspecialidad.SelectedValue; ;
            pTerapeuta.Id = TerapeutaActual.Id;

            
            int resultado = TerapeutaDAL.ModificarTerapeuta(pTerapeuta);

            if (resultado > 0)
            {

                MessageBox.Show("Terapeuta Modificado Correctamente", "Terapeuta Modificado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dtgvTerapeuta.DataSource = TerapeutaDAL.ObtenerTerapeutaParaDTGV();
                sdf.SelectedIndex = 2;

            }
            else
            {
                MessageBox.Show("No se pudo Modificar el Terapeuta", "Error!!", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation);
            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

   
      
       
        

        }
    }



