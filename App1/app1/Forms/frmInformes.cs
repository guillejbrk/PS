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
    public partial class frmInformes : MetroForm
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmTurnosPorPaciente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDConsuDataSet1.Vista3' table. You can move, or remove it, as needed.
            this.vista3TableAdapter.Fill(this.bDConsuDataSet1.Vista3);
            // TODO: This line of code loads data into the 'bDConsuDataSet.Vista2' table. You can move, or remove it, as needed.
            this.vista2TableAdapter.Fill(this.bDConsuDataSet.Vista2);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
