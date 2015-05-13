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
        

    }
}

