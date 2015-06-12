using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using App1.Clases.AccesoSQL;

namespace App1.Forms
{
    public partial class frmAdmTratamiento2 : MetroForm
    {
        public frmAdmTratamiento2()
        {
            InitializeComponent();
        }

        private void frmAdmTratamiento2_Load(object sender, EventArgs e)
        {
          



            SqlConnection Conn = BDComun.obtenerConexion();

            SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id_Tipo_Tratamiento 'CODIGO', Tipo_Tratamiento 'Descripcion',descripcion'Producto',t.costo from Tipo_Tratamiento t JOIN Productos p on t.id_Producto=p.id_producto";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dtgvTrtamiento.DataSource = dt;
            this.dtgvTrtamiento.Columns["costo"].DefaultCellStyle.Format = "c";
            Conn.Close();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {


            Int64 Id = Convert.ToInt64(dtgvTrtamiento.CurrentRow.Cells[0].Value);
            if (!TratamientoDAL.ExisteTurno(Convert.ToInt32(dtgvTrtamiento.CurrentRow.Cells[0].Value)))
            {
                TratamientoDAL.EliminarTrataiento(Id);

                MessageBox.Show("Tratamiento Eliminado", "Tratamiento Modificada", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                SqlConnection Conn = BDComun.obtenerConexion();

                SqlCommand cmd = Conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id_Tipo_Tratamiento 'CODIGO', Tipo_Tratamiento 'Descripcion',descripcion'Producto',t.costo from Tipo_Tratamiento t JOIN Productos p on t.id_Producto=p.id_producto";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dtgvTrtamiento.DataSource = dt;
                this.dtgvTrtamiento.Columns["costo"].DefaultCellStyle.Format = "c";
                Conn.Close();
            }
            else
            {
                MessageBox.Show("Atencion Existe TUrnos que se encuentran asociado a este tratamiento", "Tratamiento ", MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);
            }
                  
        }
    }
}
