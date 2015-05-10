using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using App1;
using App1.Clases;

namespace App1
{
    internal class ConsultorioDAL
    {

        public static int AgregarCliente(Cliente pCliente)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Cliente (Apellido,Nombre,Edad,Fecha_Nacimiento,Domicilio,Telefono,Celular,Correo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                            pCliente.Apellido, pCliente.Nombre, pCliente.Edad, pCliente.Fecha, pCliente.Domicilio,
                            pCliente.Tel,
                            pCliente.Cel, pCliente.Correo), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int AgregarTratamiento(Tratamiento pTratamiento)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Tipo_Tratamiento (tipo_Tratamiento,Costo) values ('{0}','{1}')",
                            pTratamiento.Descripcion, pTratamiento.Costo), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int AgregarHistoria(Historias pHistoria)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Historial (fecha,Observacion, nro_Cliente) values ('{0}','{1}','{2}')",
                            pHistoria.fecha, pHistoria.Observacion, pHistoria.id_Cliente), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int AgregarTurno(Turno pTurno)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Turno (id_Cliente,id_TipoTratamiento,Fecha,Hora,id_Terapeuta,id_Estado,Motivo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                            pTurno.id_Cliente, pTurno.id_Tratamiento, pTurno.Fecha_Tratamiento, pTurno.Hora,
                            pTurno.id_Terapeuta, pTurno.id_Estado, pTurno.Motivo), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int AgregarTerapeuta(Terapeuta pTerapeuta)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Terapeuta (Apellido,Nombre,usuario,contraseña,id_Agenda,id_Especialidad,id_Jornada) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                            pTerapeuta.Apellido, pTerapeuta.Nombre, pTerapeuta.Usuario, pTerapeuta.Contraseña,
                            pTerapeuta.id_Agenda, pTerapeuta.id_Especialidad,
                            pTerapeuta.id_Jornada), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> _lista = new List<Cliente>();

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando = new SqlCommand("select nro_cliente, Apellido,Nombre from Cliente", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();

                pCliente.Id = _reader.GetInt32(0);
                pCliente.Apellido = _reader.GetString(1);
                pCliente.Nombre = _reader.GetString(2);


                _lista.Add(pCliente);
            }

            return _lista;
        }


        public static List<Tratamiento> ObtenerTratamiento()
        {
            List<Tratamiento> _listaTratamiento = new List<Tratamiento>();

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando =
                new SqlCommand("select id_Tipo_Tratamiento, tipo_Tratamiento, Costo from Tipo_Tratamiento", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Tratamiento pTratamiento = new Tratamiento();

                pTratamiento.Id = _reader.GetInt32(0);
                pTratamiento.Descripcion = _reader.GetString(1);
                pTratamiento.Costo = _reader.GetDecimal(2);


                _listaTratamiento.Add(pTratamiento);
            }

            return _listaTratamiento;
        }

        public static List<Terapeuta> ObtenerTerapeuta()
        {
            List<Terapeuta> _listaTerapeutas = new List<Terapeuta>();

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando = new SqlCommand("select id_terapeuta,Apellido from Terapeuta", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Terapeuta pTerapeuta = new Terapeuta();

                pTerapeuta.Id = _reader.GetInt32(0);
                pTerapeuta.Apellido = _reader.GetString(1);



                _listaTerapeutas.Add(pTerapeuta);
            }

            return _listaTerapeutas;
        }


        public static List<Cliente> BuscarClientes(String pApellido)
        {

            List<Cliente> Lista = new List<Cliente>();
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select nro_Cliente,Apellido,Nombre,Edad,Fecha_Nacimiento,Domicilio,Telefono,Celular,Correo from Cliente where Apellido like '%{0}%' ",
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
                    pCliente.Tel = reader.GetInt32(6);
                    pCliente.Cel = reader.GetInt32(7);
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
                  "Select nro_Cliente,Apellido,Nombre,Edad,Fecha_Nacimiento,Domicilio,Telefono,Celular,Correo from Cliente where nro_Cliente = {0} ",
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
                    pCliente.Tel = reader.GetInt32(6);
                    pCliente.Cel = reader.GetInt32(7);
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
                   (string.Format("Update Cliente set Apellido='{0}', Nombre='{1}', Edad='{2}', Fecha_Nacimiento='{3}',Domicilio='{4}',Telefono='{5}',Celular='{6}', Correo='{7}' where nro_Cliente={8}",
                   pCliente.Apellido, pCliente.Nombre, pCliente.Edad, pCliente.Fecha, pCliente.Domicilio,pCliente.Tel,pCliente.Cel,pCliente.Correo,pCliente.Id), conexion);

                     

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }

    }
}

