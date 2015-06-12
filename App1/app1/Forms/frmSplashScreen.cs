using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App1.Forms
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        
            Tiempo.Enabled = true;
            Tiempo.Interval = 400;
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            progBarr.Value = progBarr.Value + 20;
            progBarr.Style = ProgressBarStyle.Continuous;
            if (Convert.ToInt32(progBarr.Value) == 100)
            {
                Tiempo.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

      
    }
}
