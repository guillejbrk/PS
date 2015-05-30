using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace App1.Clases.AccesoSQL
{
    class HistoriaDAL
    {
        public static int AgregarHistoria(Historias pHistorias)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Historial (Fecha,Observacion,nro_Cliente) values ('{0}','{1}','{2}')",
                            pHistorias.Fecha, pHistorias.Observacion, pHistorias.idPaciente), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> _lista = new List<Cliente>();

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando = new SqlCommand("select nro_Paciente, Apellido,Nombre, Apellido+' '+Nombre as NOMBRECOMPLETO from Paciente", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();

                pCliente.Id = _reader.GetInt32(0);
                pCliente.Apellido = _reader.GetString(3);
                pCliente.Nombre = _reader.GetString(2);


                _lista.Add(pCliente);
            }

            return _lista;
        }

        public static List<Cliente> BuscarClientes2(String pApellido)
        {

            List<Cliente> Lista = new List<Cliente>();
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select nro_Paciente,Apellido,Nombre,Edad,Fecha_Nacimiento,Domicilio,Telefono,Celular,Correo from Paciente where Apellido like '%{0}%' ",
                    pApellido), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cliente pCliente = new Cliente();

                    pCliente.Id = reader.GetInt32(0);
                    pCliente.Apellido = reader.GetString(1);
                    pCliente.Nombre = reader.GetString(2);
                    pCliente.Edad = reader.GetInt32(3);
                    pCliente.Fecha = Convert.ToString(reader.GetDateTime(4));
                    pCliente.Domicilio = reader.GetString(5);
                    pCliente.Tel = reader.GetString(6);
                    pCliente.Cel = reader.GetString(7);
                    pCliente.Correo = reader.GetString(8);


                    Lista.Add(pCliente);

                }
                conexion.Close();
                return Lista;

            }

        }


        public static List<Historias> ObtenerFecha(Int64 pNro_Cliente)
        {

            using (SqlConnection conexion = BDComun.obtenerConexion())
            {

                  List<Historias> lista = new List<Historias>();

                SqlCommand comando = new SqlCommand(string.Format(
                    "Select id_Historial, Fecha ,Observacion,nro_Paciente from Historial where nro_Paciente = {0} ",
                    pNro_Cliente), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                  Historias pHistoria = new Historias();
                    pHistoria.Id = reader.GetInt32(0);
                    pHistoria.Fecha = reader.GetDateTime(1).ToShortDateString();
                    pHistoria.Observacion = reader.GetString(2);
                    pHistoria.idPaciente = reader.GetInt32(3);

                    lista.Add(pHistoria);
                 
                }

                conexion.Close();

                return lista;

            }

    }


        public static Historias ObtenerObservacion(Int64 pNro_Cliente, string pFecha)
        {

            using (SqlConnection conexion = BDComun.obtenerConexion())
            {

                Historias pHistoria = new Historias();

                SqlCommand comando = new SqlCommand(string.Format(
                    "Select id_Historial, Fecha ,Observacion,nro_Paciente from Historial where nro_Paciente = {0} and Fecha= {1} ",
                    pNro_Cliente, pFecha), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                   
                    pHistoria.Id = reader.GetInt32(0);
                    pHistoria.Fecha = reader.GetDateTime(1).ToShortDateString();
                    pHistoria.Observacion = reader.GetString(2);
                    pHistoria.idPaciente = reader.GetInt32(3);

                 

                }

                conexion.Close();

                return pHistoria;

            }

        }
    }


}
