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
using System.Data.SqlClient;

namespace App1.Forms
{
    public partial class frmPacienteTurnos : MetroForm
    {


        public frmPacienteTurnos()
        {
            InitializeComponent();
        }

        private void frmPacienteTurnos_Load(object sender, EventArgs e)
        {
            cmbPaciente.DataSource = ClienteDAL.ObtenerClientes();
            cmbPaciente.DisplayMember = "Apellido";
            cmbPaciente.ValueMember = "Id";


        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Conn = BDComun.obtenerConexion();
             dtgvTurnosPaciente.DataSource = null;
             SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Apellido,Nombre,Fecha,hora,Estado,Motivo from Turno t JOIN Paciente p on t.id_Paciente = p.nro_Paciente JOIN Estado_Turnos e on t.id_Estado=e.id_Estado_Turno where  id_Paciente='" + (((Cliente)cmbPaciente.SelectedItem).Id) + "' ";
             cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dtgvTurnosPaciente.DataSource = dt;

            Conn.Close();



           // dtgvTurnosPaciente.DataSource = TurnosDAL.DiasDeAltaOCanceladoPorPaciente(((Cliente)cmbPaciente.SelectedItem).Id);


        }
    }
}
