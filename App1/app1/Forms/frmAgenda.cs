using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

using MetroFramework.Forms;

namespace App1.Forms
{
    public partial class frmAgenda : MetroForm
    {
        private SqlConnection conexion = new SqlConnection(@"data source=KRUSCHOV\SQLEXPRESS; initial catalog=P7; user Id=sa; Password=guille");

        public frmAgenda()
        {

            InitializeComponent();

        }

      

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from Agenda";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dtGVDiasLaborables.DataSource = dt;

            conexion.Close();
        }
    }
}
