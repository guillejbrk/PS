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


namespace App1.Forms
{
    public partial class Turnos : MetroForm
    {
          SqlConnection conexion = new SqlConnection(@"data source=KRUSCHOV\SQLEXPRESS; initial catalog=BDConsu; user Id=sa; Password=guille");
        public Turnos()
        {
          
            InitializeComponent();

        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Apellido,Nombre, tipo_Tratamiento 'Tratamiento',Fecha,hora" +
                              " FROM Turno tu JOIN Paciente cl on tu.id_Paciente=cl.nro_Paciente " +
                              "JOIN Tipo_Tratamiento tt on tu.id_TipoTratamiento=tt.id_Tipo_Tratamiento" +
                              " where Fecha = ('" + mcaleTurno.SelectionEnd.ToShortDateString() + "') ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dtgvTurnos.DataSource = dt;

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mcaleTurno_DateChanged(object sender, DateRangeEventArgs e)
        {
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Apellido,Nombre, tipo_Tratamiento 'Tratamiento',Fecha,hora" +
                              " FROM Turno tu JOIN Paciente cl on tu.id_Paciente=cl.nro_Paciente " +
                              "JOIN Tipo_Tratamiento tt on tu.id_TipoTratamiento=tt.id_Tipo_Tratamiento" +
                              " where Fecha = ('" + mcaleTurno.SelectionEnd.ToShortDateString() + "') ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dtgvTurnos.DataSource = dt;

            conexion.Close();

        }

    }
}
