using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace App1
{
      class BDComun
    {
        public static SqlConnection obtenerConexion()

        {

            SqlConnection Conn=new SqlConnection(@"data source=KRUSCHOV\SQLEXPRESS; initial catalog=BDConsu; user Id=sa; Password=guille");
            Conn.Open();
            return Conn;
        }
    }
}

