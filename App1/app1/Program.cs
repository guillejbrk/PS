using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using App1.Forms;

namespace App1
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static String usuario = "";//variable publica
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmSplashScreen sp = new frmSplashScreen();
            if (sp.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmLog());
            }
        }
    }
}
