using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using App1.Properties;
using System.Configuration;
namespace App1
{
      class BDComun
    {

          public static string ObtenerString()
          {
              return Settings.Default.BDConsuConnectionString;
          }
        public static SqlConnection obtenerConexion()

        {

            SqlConnection Conn=new SqlConnection(ObtenerString());
            Conn.Open();
            return Conn;
        }
    }
}

