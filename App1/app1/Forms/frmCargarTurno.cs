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
using System.Globalization;
using System.Threading;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace App1.Forms
{
    public partial class frmCargarTurno : MetroForm
    {

        
        public frmCargarTurno()
        {
           
            InitializeComponent();
        }

        private void frmCargarTurno_Load(object sender, EventArgs e)
        {
            frmCargarCliente frmCargar = new frmCargarCliente();

          

            cboPaciente.DataSource = ClienteDAL.ObtenerClientes();
            cboPaciente.DisplayMember = "Apellido";
            cboPaciente.ValueMember = "Id";
           

            cboTratamiento.DataSource = TratamientoDAL.ObtenerTratamiento();
            cboTratamiento.DisplayMember = "Descripcion";
            cboTratamiento.ValueMember = "Id";

            cboTerapeuta.DataSource = TerapeutaDAL.ObtenerTerapeuta();
            cboTerapeuta.DisplayMember = "Apellido";
            cboTerapeuta.ValueMember = "Id";


            rbnAlta.Enabled = false;
            rbnCancelado.Enabled = false;
            rbtInactivo.Enabled = false;
            

            if (rbnCancelado.Checked)
            {
                panelCanelado.Visible = true;
            }
            else
            {
                panelCanelado.Visible = false;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            frmCargarCliente frmCargar= new frmCargarCliente();
             frmCargar.ShowDialog();
            
        }    

        private void rbnCancelado_CheckedChanged(object sender, EventArgs e)
        {
            panelCanelado.Visible = true;
            txtMotivo.Visible = true;
        }

        private void rbnAlta_CheckedChanged(object sender, EventArgs e)
        {
            panelCanelado.Visible = false;
        }
        
        private void cboPaciente_MouseClick(object sender, MouseEventArgs e)
        {
            frmCargarCliente frmCargar = new frmCargarCliente();
            cboPaciente.DataSource = ClienteDAL.ObtenerClientes();

            cboPaciente.DisplayMember = "Apellido";
            cboPaciente.ValueMember = "Id";
        }

        private void cboTerapeuta_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            SqlConnection Conn = BDComun.obtenerConexion();
            dtgvTurnos.DataSource = null;
            SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id_Turno 'Nro. Turno', Apellido,Nombre,Fecha,hora,Estado,Motivo from Turno t JOIN Paciente p on t.id_Paciente = p.nro_Paciente JOIN Estado_Turnos e on t.id_Estado=e.id_Estado_Turno where  id_Terapeuta='" + (((Terapeuta)cboTerapeuta.SelectedItem).Id) + "' and Fecha between '" + DateTime.Now.ToShortDateString() + "' and '"+ DateTime.Now.AddDays(365).ToShortDateString()+"'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dtgvTurnos.DataSource = dt;

            Conn.Close();
       




            var cultureInfo = new CultureInfo("es-Ar");
            var dateTimeInfo = cultureInfo.DateTimeFormat;
            var dayNames = dateTimeInfo.DayNames;

            List<string> Listadedias = new List<string>();
            List<DayOfWeek> L = AgendaDAL.ObtenerListaDias(((Terapeuta)cboTerapeuta.SelectedItem).Id);
            foreach (DayOfWeek item in L)
            {
                Listadedias.Add(dayNames[(int)item]);
            }
            cboDia.DataSource = null;
            cboDia.DataSource = Listadedias;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmAdmTratamiento frmCargarTra = new frmAdmTratamiento();
            frmCargarTra.ShowDialog();
        }

        private void cboTratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTratamiento_MouseClick(object sender, MouseEventArgs e)
        {

            cboTratamiento.DataSource = TratamientoDAL.ObtenerTratamiento();
            cboTratamiento.DisplayMember = "Descripcion";
            cboTratamiento.ValueMember = "Id";
        }

        private void lstDias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (lstDias.SelectedItem != null)
            {
                Turno t = (Turno)lstDias.SelectedItem;
                if (t.id_Estado == 3 || t.id_Estado == 2)
                {
                    t.id_Estado = 1;
                    t.id_Tratamiento = ((Tratamiento)cboTratamiento.SelectedItem).Id;
                    t.Motivo = "";
                    t.id_Cliente = ((Cliente)cboPaciente.SelectedItem).Id;
                    TurnosDAL.ActualizarTurno(t);
                    MessageBox.Show("Turno Dado de Alta", "Turno", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlConnection Conn = BDComun.obtenerConexion();
                    dtgvTurnos.DataSource = null;
                    SqlCommand cmd = Conn.CreateCommand();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select id_Turno 'Nro. Turno', Apellido,Nombre,Fecha,hora,Estado,Motivo from Turno t JOIN Paciente p on t.id_Paciente = p.nro_Paciente JOIN Estado_Turnos e on t.id_Estado=e.id_Estado_Turno where  id_Terapeuta='" + (((Terapeuta)cboTerapeuta.SelectedItem).Id) + "' and Fecha between '" + DateTime.Now.ToShortDateString() + "' and '" + DateTime.Now.AddDays(365).ToShortDateString() + "'";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dtgvTurnos.DataSource = dt;

                    Conn.Close();
       
       

                    DayOfWeek d = DayOfWeekConverter.ConvertBack((string)cboDia.SelectedItem);
                    List<Turno> turnosdisponibles = TurnosDAL.ObtenerTurnosDelMes(((Terapeuta)(cboTerapeuta.SelectedItem)).Id, d);
                    lstDias.DataSource = null;
                    lstDias.DataSource = turnosdisponibles;
                    lstDias.DisplayMember = "Feyhora";

                }
                else
                {
                    if (rbnCancelado.Checked)
                    {
                        t.id_Estado = 2;
                        t.id_Tratamiento = ((Tratamiento)cboTratamiento.SelectedItem).Id;
                        t.Motivo = txtMotivo.Text;
                        t.id_Cliente = ((Cliente)cboPaciente.SelectedItem).Id;
                        TurnosDAL.ActualizarTurno(t);
                        MessageBox.Show("Turno Cancelado Correctamente", "Turno", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SqlConnection Conn = BDComun.obtenerConexion();
                        dtgvTurnos.DataSource = null;
                        SqlCommand cmd = Conn.CreateCommand();

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select id_Turno 'Nro. Turno', Apellido,Nombre,Fecha,hora,Estado,Motivo from Turno t JOIN Paciente p on t.id_Paciente = p.nro_Paciente JOIN Estado_Turnos e on t.id_Estado=e.id_Estado_Turno where  id_Terapeuta='" + (((Terapeuta)cboTerapeuta.SelectedItem).Id) + "' and Fecha between '" + DateTime.Now.ToShortDateString() + "' and '" + DateTime.Now.AddDays(365).ToShortDateString() + "'";
                        cmd.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(dt);

                        dtgvTurnos.DataSource = dt;

                        Conn.Close();
       
       

                        DayOfWeek d = DayOfWeekConverter.ConvertBack((string)cboDia.SelectedItem);
                        List<Turno> turnosdisponibles = TurnosDAL.ObtenerTurnosDelMes(((Terapeuta)(cboTerapeuta.SelectedItem)).Id, d);
                        lstDias.DataSource = null;
                        lstDias.DataSource = turnosdisponibles;
                        lstDias.DisplayMember = "Feyhora";
                    }
                    else
                    {
                        MessageBox.Show("Turno ya dado de Alta", "Turno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione Primero Un Dia", "Turno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cultureInfo = new CultureInfo("es-Ar");
            var dateTimeInfo = cultureInfo.DateTimeFormat;
            var dayNames = dateTimeInfo.DayNames;

            DayOfWeek d = DayOfWeekConverter.ConvertBack((string)cboDia.SelectedItem);
            List<Turno> turnosdisponibles = TurnosDAL.ObtenerTurnosDelMes(((Terapeuta)(cboTerapeuta.SelectedItem)).Id, d);

            lstDias.DataSource = null;
            lstDias.DataSource = turnosdisponibles;
            lstDias.DisplayMember = "Feyhora";
        }

        private void lstDias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstDias.SelectedItem != null)
            {
                switch ((((Turno)lstDias.SelectedItem).id_Estado))
                {
                    case 1:
                        rbnAlta.Checked = true;
                        rbnCancelado.Checked = false;
                        rbtInactivo.Checked = false;
                        break;
                    case 2:
                        rbnAlta.Checked = false;
                        rbnCancelado.Checked = true;
                        rbtInactivo.Checked = false;
                        break;
                    case 3:
                        rbnAlta.Checked = false;
                        rbnCancelado.Checked = false;
                        rbtInactivo.Checked = true;
                        break;
                    default:
                        break;
                }
            }

        }

        private void btnImprimirTurno_Click(object sender, EventArgs e)
                            {
                                 


                                 string textToPrint = "Su Proximo Turno: \n";
                                for (int row = 0; row < dtgvTurnos.SelectedRows.Count; row++)
                                {
                                     
                                    textToPrint = textToPrint +
                                    dtgvTurnos.SelectedRows[row].Cells[0].Value.ToString() + "\n"+""+"Nombre: " +" "+
                                    dtgvTurnos.SelectedRows[row].Cells[1].Value.ToString() + " " +
                                    dtgvTurnos.SelectedRows[row].Cells[2].Value.ToString() + "\n" +"Dia: "+
                                    dtgvTurnos.SelectedRows[row].Cells[3].Value.ToString() + "\n" + "Hora: " +
                                    dtgvTurnos.SelectedRows[row].Cells[4].Value.ToString() + "\n";
                                }

                                string s = textToPrint;
                               
                                        PrintDialog pdi = new PrintDialog();
                                        PrintDocument p = new PrintDocument();
                                        p.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
                                        {
                                            System.Drawing.Image img = System.Drawing.Image.FromFile("C:\\Users\\Guille\\Documents\\GitHub\\PS\\App1\\PS\\App1\\App1\\Resources\\as.png");
                                            Point loc = new Point(190, 00);
                                            e1.Graphics.DrawImage(img, loc);
                                            
                                            e1.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 30, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
                                           
                                        };
                                        try
                                        {
                                            pdi.Document = p;
                                            if (pdi.ShowDialog() == DialogResult.OK)
                                            {
                                                p.Print();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Print Cancelled");
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                        throw new Exception("Exception Occured While Printing", ex);
                                        }
                                }
      
        private void btnCancelar_Click(object sender, EventArgs e)
        {


            if (validar()==true)
            {
                Turno pTurno = new Turno();
                pTurno.Id = Convert.ToInt64(dtgvTurnos.CurrentRow.Cells[0].Value);
                pTurno.id_Estado = 2;
                pTurno.Motivo = txtMotivo.Text;

                TurnosDAL.ActualizarTurnosCancelar(pTurno);
                panelCanelado.Visible = true;

                MessageBox.Show("Turno Cancelado Correctamente", "Turno", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlConnection Conn = BDComun.obtenerConexion();
                dtgvTurnos.DataSource = null;
                SqlCommand cmd = Conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id_Turno 'Nro. Turno', Apellido,Nombre,Fecha,hora,Estado,Motivo from Turno t JOIN Paciente p on t.id_Paciente = p.nro_Paciente JOIN Estado_Turnos e on t.id_Estado=e.id_Estado_Turno where  id_Terapeuta='" + (((Terapeuta)cboTerapeuta.SelectedItem).Id) + "' and Fecha between '" + DateTime.Now.ToShortDateString() + "' and '" + DateTime.Now.AddDays(365).ToShortDateString() + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dtgvTurnos.DataSource = dt;

                Conn.Close();
       
                DayOfWeek d = DayOfWeekConverter.ConvertBack((string)cboDia.SelectedItem);
                List<Turno> turnosdisponibles = TurnosDAL.ObtenerTurnosDelMes(((Terapeuta)(cboTerapeuta.SelectedItem)).Id, d);
                
                lstDias.DataSource = null;
                lstDias.DataSource = turnosdisponibles;
                lstDias.DisplayMember = "Feyhora";
            }
            
        }

        private bool validar()
        {
            if (txtMotivo.Text == "")
            {
                MessageBox.Show("No se Olvide de Cargar El Motivo!", "Turno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMotivo.Focus();
                panelCanelado.Visible = true;
                txtMotivo.Visible = true;
                return false;
            }
           

            return true;
        }

      
  
    

      
    }
}
