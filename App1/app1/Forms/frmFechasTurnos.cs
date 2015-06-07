using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using App1.Clases.AccesoSQL;
using App1.Clases;


namespace App1.Forms
{
    public partial class Turnos : MetroForm
    {
    
        public Turnos()
        {
          
            InitializeComponent();

        }

        private void frmPrueba_Load(object sender, EventArgs e)
         {

             cboTerapeuta.DataSource = TerapeutaDAL.ObtenerTerapeuta();
             cboTerapeuta.DisplayMember = "Apellido";
             cboTerapeuta.ValueMember = "Id";




            SqlConnection Conn = BDComun.obtenerConexion();
            dtgvTurnos.DataSource = null;
            SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Apellido,Nombre, tipo_Tratamiento 'Tratamiento',hora" +
                              " FROM Turno tu JOIN Paciente cl on tu.id_Paciente=cl.nro_Paciente " +
                              "JOIN Tipo_Tratamiento tt on tu.id_TipoTratamiento=tt.id_Tipo_Tratamiento" +
                              " where Fecha = ('" + mcaleTurno.SelectionEnd.ToShortDateString() + "') and id_Terapeuta='" + cboTerapeuta.SelectedValue + "' ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dtgvTurnos.DataSource = dt;

            Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mcaleTurno_DateChanged(object sender, DateRangeEventArgs e)
        {
            SqlConnection Conn = BDComun.obtenerConexion();
            dtgvTurnos.DataSource = null;
            SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Apellido,Nombre, tipo_Tratamiento 'Tratamiento',hora" +
                              " FROM Turno tu JOIN Paciente cl on tu.id_Paciente=cl.nro_Paciente " +
                              "JOIN Tipo_Tratamiento tt on tu.id_TipoTratamiento=tt.id_Tipo_Tratamiento" +
                              " where Fecha = ('" + mcaleTurno.SelectionEnd.ToShortDateString() + "') and id_Terapeuta='" + cboTerapeuta.SelectedValue + "' ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dtgvTurnos.DataSource = dt;

            Conn.Close();

        }

        private void cboTerapeuta_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection Conn = BDComun.obtenerConexion();
            dtgvTurnos.DataSource = null;
            SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Apellido,Nombre, tipo_Tratamiento 'Tratamiento',hora" +
                              " FROM Turno tu JOIN Paciente cl on tu.id_Paciente=cl.nro_Paciente " +
                              "JOIN Tipo_Tratamiento tt on tu.id_TipoTratamiento=tt.id_Tipo_Tratamiento" +
                              " where Fecha = ('" + mcaleTurno.SelectionEnd.ToShortDateString() + "') and id_Terapeuta='" + cboTerapeuta.SelectedValue + "' ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dtgvTurnos.DataSource = dt;

            Conn.Close();
        }

        private void cboTerapeuta_SelectedIndexChanged(object sender, EventArgs e)
        {

            dtgvTurnos.DataSource = null;
           
        }

       

    }
}
