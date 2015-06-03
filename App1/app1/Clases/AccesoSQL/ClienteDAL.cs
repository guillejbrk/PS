using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App1.Clases.AccesoSQL
{
    internal class ClienteDAL
    {

        public static int AgregarCliente(Cliente pCliente)

        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Paciente (Apellido,Nombre,Edad,Fecha_Nacimiento,Domicilio,Telefono,Celular,Correo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                            pCliente.Apellido, pCliente.Nombre, pCliente.Edad, pCliente.Fecha, pCliente.Domicilio,
                            pCliente.Tel,
                            pCliente.Cel, pCliente.Correo), Conn);

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

        public static List<Cliente> BuscarClientes(String pApellido)
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
                    pCliente.Fecha = reader.GetDateTime(4).ToShortDateString();
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

        public static Cliente ObtenerCliente2(Int64 pId)
        {

            using (SqlConnection conexion = BDComun.obtenerConexion())
            {

                Cliente pCliente = new Cliente();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select nro_Paciente,Apellido,Nombre,Edad,Fecha_Nacimiento,Domicilio,Telefono,Celular,Correo from Paciente where nro_Paciente = {0} ",
                    pId), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pCliente.Id = reader.GetInt32(0);
                    pCliente.Apellido = reader.GetString(1);
                    pCliente.Nombre = reader.GetString(2);
                    pCliente.Edad = reader.GetInt32(3);
                    pCliente.Fecha = Convert.ToString(reader.GetDateTime(4));
                    pCliente.Domicilio = reader.GetString(5);
                    pCliente.Tel = reader.GetString(6);
                    pCliente.Cel = reader.GetString(7);
                    pCliente.Correo = reader.GetString(8);




                }
                conexion.Close();
                return pCliente;

            }

        }

        public static int Modificar(Cliente pCliente)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand
                    (string.Format(
                        "Update Paciente set Apellido='{0}', Nombre='{1}', Edad='{2}', Fecha_Nacimiento='{3}',Domicilio='{4}',Telefono='{5}',Celular='{6}', Correo='{7}' where nro_Paciente={8}",
                        pCliente.Apellido, pCliente.Nombre, pCliente.Edad, pCliente.Fecha, pCliente.Domicilio,
                        pCliente.Tel, pCliente.Cel, pCliente.Correo, pCliente.Id), conexion);



                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

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
                    pCliente.Fecha = reader.GetDateTime(4).ToShortDateString();
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

    }
}
