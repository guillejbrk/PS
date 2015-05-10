using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App1.Clases;

namespace App1.Forms
{
    public partial class frmAdmPaciente : Form
    {

        
         SqlConnection conexion = new SqlConnection(@"data source=KRUSCHOV\SQLEXPRESS; initial catalog=PS6; user Id=sa; Password=guille");
       
      
        
        public frmAdmPaciente()
        {
            InitializeComponent();
        }


        
       


        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
