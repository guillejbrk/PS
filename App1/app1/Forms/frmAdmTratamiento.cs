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
using System.Data.SqlClient;

namespace App1.Forms
{
    public partial class frmAdmTratamiento : MetroForm
    {
        SqlConnection conexion = new SqlConnection(@"data source=KRUSCHOV\SQLEXPRESS; initial catalog=BDConsu; user Id=sa; Password=guille");
        public frmAdmTratamiento()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdmTratamiento_Load(object sender, EventArgs e)
        {
            cbmProducto.DataSource = TratamientoDAL.ObtenerProductos();
            cbmProducto.DisplayMember = "Descripcion";
            cbmProducto.ValueMember = "Id";
           


            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id_Tipo_Tratamiento 'CODIGO', Tipo_Tratamiento 'Descripcion',descripcion'Producto',t.costo from Tipo_Tratamiento t JOIN Productos p on t.id_Producto=p.id_producto";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dtgvTrtamiento.DataSource = dt;
            this.dtgvTrtamiento.Columns["costo"].DefaultCellStyle.Format = "c";
            conexion.Close();
        }     

        private bool validar()
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("Debe ingresar Nombre Tratamiento...");
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Debe ingresar Costo Tratamiento...");
                textBox2.Focus();
                return false;
            }


            return true;
        }

        private void btnCargarTratamiento_Click(object sender, EventArgs e)
        {
            Tratamiento pTratamiento = new Tratamiento();
            if (validar())
            {

                pTratamiento.Descripcion = textBox1.Text;
                pTratamiento.IdProducto = Convert.ToInt64(cbmProducto.SelectedValue);
                pTratamiento.Costo = Convert.ToDecimal(textBox2.Text);


                int resultado = TratamientoDAL.AgregarTratamiento(pTratamiento);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Ingresados Correctamente", "Datos Guardados", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    conexion.Open();

                    SqlCommand cmd = conexion.CreateCommand();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select id_Tipo_Tratamiento, Tipo_Tratamiento 'Descripcion',descripcion'Producto',t.costo from Tipo_Tratamiento t JOIN Productos p on t.id_Producto=p.id_producto";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dtgvTrtamiento.DataSource = dt;

                    conexion.Close();

                     
                 

                }
                else
                {
                    MessageBox.Show("No se pudo Guardar", "Error al Guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {            
          Int64 Id = Convert.ToInt64(dtgvTrtamiento.CurrentRow.Cells[0].Value);
                       TratamientoDAL.EliminarTrataiento(Id);

                            MessageBox.Show("Tratamiento Eliminado", "Tratamiento Modificada", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                            conexion.Open();

                            SqlCommand cmd = conexion.CreateCommand();

                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "select id_Tipo_Tratamiento 'CODIGO', Tipo_Tratamiento 'Descripcion',descripcion'Producto',t.costo from Tipo_Tratamiento t JOIN Productos p on t.id_Producto=p.id_producto";
                            cmd.ExecuteNonQuery();

                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);

                            da.Fill(dt);

                            dtgvTrtamiento.DataSource = dt;
                            this.dtgvTrtamiento.Columns["costo"].DefaultCellStyle.Format = "c";
                            conexion.Close();
                          
                  
        } 
      

        }      

    }

