﻿using System;
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
            dgvProductos.DataSource = ProductosDAL.ObtenerProductoss(((Terapeuta)cboTerapeuta.SelectedItem).Id);
            dgvProductos.Columns["id_Terapeuta"].Visible = false;
            dgvProductos.Columns["Costo"].DefaultCellStyle.Format = "c";
        }

        private void cboTerapeuta_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvProductos.DataSource = ProductosDAL.ObtenerProductoss(((Terapeuta)cboTerapeuta.SelectedItem).Id);
            dgvProductos.Columns["id_Terapeuta"].Visible = false;
           dgvProductos.Columns["Costo"].DefaultCellStyle.Format = "c";
            decimal costoTotal = 0;
            for (int row = 0; row < dgvProductos.Rows.Count; row++)
            {


            decimal costo = decimal.Parse(dgvProductos.Rows[row].Cells[2].Value.ToString());
           Int64 cantidad = Int64.Parse(dgvProductos.Rows[row].Cells[3].Value.ToString());
           costoTotal = costoTotal + costo * cantidad;


            }
            label1.Text = "$" + costoTotal.ToString("#.##");
           
        }

       

      

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            frmProductos pProductos = new frmProductos();
            pProductos.Show();
            this.Close();
        }

        private void btnQuitar_Click_1(object sender, EventArgs e)
        {  if(ProductosDAL.ExisteTerapeuta(Convert.ToInt32(cboTerapeuta.SelectedValue)))
            {
                 if (!ProductosDAL.ExisteTratamiento(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value)))
                      { Int64 Id = Convert.ToInt64(dgvProductos.CurrentRow.Cells[0].Value);

                        ProductosDAL.EliminarProductos(Id);

                        MessageBox.Show("Producto Eliminado", "Agenda Modificada", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        dgvProductos.DataSource = ProductosDAL.ObtenerProductoss(((Terapeuta)cboTerapeuta.SelectedItem).Id);
                        dgvProductos.Columns["id_Terapeuta"].Visible = false;          
                        this.dgvProductos.Columns["Costo"].DefaultCellStyle.Format = "c";
                        decimal costoTotal = 0;
                        for (int row = 0; row < dgvProductos.Rows.Count; row++)
                        {


                            decimal costo = decimal.Parse(dgvProductos.Rows[row].Cells[2].Value.ToString());
                            Int64 cantidad = Int64.Parse(dgvProductos.Rows[row].Cells[3].Value.ToString());
                            costoTotal = costoTotal + costo * cantidad;


                        }
                        label1.Text = "$" + costoTotal.ToString("#.##");
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

       
    }
}
