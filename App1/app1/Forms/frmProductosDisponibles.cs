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
using App1.Clases;

namespace App1.Forms
{
    public partial class frmProductosDisponibles : MetroForm
    {
        public frmProductosDisponibles()
        {
            InitializeComponent();
        }

        private void frmProductosDisponibles_Load(object sender, EventArgs e)
        {
            cboTerapeuta.DataSource = TerapeutaDAL.ObtenerTerapeuta();
            cboTerapeuta.DisplayMember = "Apellido";
            cboTerapeuta.ValueMember = "Id";

        }

        private void cboTerapeuta_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvProductos.DataSource = ProductosDAL.ObtenerProductoss(((Terapeuta)cboTerapeuta.SelectedItem).Id);
            dgvProductos.Columns["id_Terapeuta"].Visible = false;
        
            this.dgvProductos.Columns["Costo"].DefaultCellStyle.Format = "c";


        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            frmProductos pProductos = new frmProductos();
            pProductos.ShowDialog();
            this.Close();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(ProductosDAL.ExisteTerapeuta(Convert.ToInt32(cboTerapeuta.SelectedValue)))
            {
                 if (!ProductosDAL.ExisteTratamiento(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value)))
                      { Int64 Id = Convert.ToInt64(dgvProductos.CurrentRow.Cells[0].Value);

                        ProductosDAL.EliminarProductos(Id);

                        MessageBox.Show("Producto Eliminado", "Agenda Modificada", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        dgvProductos.DataSource = ProductosDAL.ObtenerProductoss(((Terapeuta)cboTerapeuta.SelectedItem).Id);
                        dgvProductos.Columns["id_Terapeuta"].Visible = false;          
                        this.dgvProductos.Columns["Costo"].DefaultCellStyle.Format = "c";
                      }
                else
                {
                    MessageBox.Show("Primeo Debe eliminar Tratamiento Asociado", "Atencion!", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                 MessageBox.Show("No Existe Productos Asociados", "Atencion!", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }

           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
