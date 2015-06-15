using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace App1.Forms
{
    public partial class frmInformes2 : MetroForm
    {
        public frmInformes2()
        {
            InitializeComponent();
        }

        private void frmInformes2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtGastos.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.dtGastos.Productos);

            this.reportViewer1.RefreshReport();
        }
    }
}
