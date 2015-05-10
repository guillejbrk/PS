using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace App1.Clases
{
    class AccesoDatos
    {
        private OleDbConnection conexion;
        private OleDbCommand comando;
        private OleDbDataReader lectorReg;
        private string cadenaConexion;

     

        public static SqlConnection obtenerConexion()
        {

            SqlConnection Conn = new SqlConnection(@"data source=KRUSCHOV\SQLEXPRESS; initial catalog=P7; user Id=sa; Password=guille");
            Conn.Open();

            return Conn;
        }
        public OleDbDataReader pLector
        {
            set { lectorReg = value; }
            get { return lectorReg; }
        }

        public string pCadenaconexion
        {
            set { cadenaConexion = value; }
            get { return cadenaConexion; }
        }

        public void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void desconectar()
        {
            conexion.Close();
        }

        
        public void CrearDR(string tabla) /*leer tabla*/
        {
            conectar();
            comando.CommandText = "SELECT * FROM " + tabla;
            lectorReg = comando.ExecuteReader();

        }
        
        public DataTable CrearDT(string tabla) /*consultar tabla*/
        {
            DataTable dt = new DataTable();
            conectar();
            comando.CommandText = "SELECT * FROM " + tabla;
            dt.Load(comando.ExecuteReader());
            desconectar();
            return dt;

        }
        public DataTable consultar(string sql)
        {
            DataTable dt = new DataTable();
            conectar();
            comando.CommandText = sql;
            dt.Load(comando.ExecuteReader());
            desconectar();
            return dt;
        }

        public void actualizar(string sql)
        {
            conectar();
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            desconectar();

           
        }
    }
}

 