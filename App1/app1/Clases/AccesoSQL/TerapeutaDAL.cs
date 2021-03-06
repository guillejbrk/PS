﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace App1.Clases.AccesoSQL
{
    class TerapeutaDAL
    {
        public static int AgregarTerapeuta(Terapeuta pTerapeuta)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Terapeuta (Apellido,Nombre,usuario,contraseña,id_Jornada,id_Especialidad) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                            pTerapeuta.Apellido, pTerapeuta.Nombre, pTerapeuta.Usuario, pTerapeuta.Contraseña,
                            pTerapeuta.Id_Jornada, pTerapeuta.Id_Especialidad), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;



        }

        public static List<Terapeuta> ObtenerTerapeuta()
        {
            List<Terapeuta> _listaTerapeutas = new List<Terapeuta>();

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando = new SqlCommand("select id_Terapeuta, Apellido,Nombre,Apellido+' '+Nombre as NOMBRECOMPLETO from Terapeuta", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Terapeuta pTerapeuta = new Terapeuta();

                pTerapeuta.Id = _reader.GetInt32(0);
                pTerapeuta.Apellido = _reader.GetString(3);
                pTerapeuta.Nombre = _reader.GetString(2);



                _listaTerapeutas.Add(pTerapeuta);
            }

            return _listaTerapeutas;
        }


        public static Terapeuta ObtenerTerapeuta(Int64 pIdTerapeuta)
        {
            Terapeuta pTerapeuta = new Terapeuta();

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando = new SqlCommand("select id_Terapeuta, Apellido,Nombre,Apellido+' '+Nombre as NOMBRECOMPLETO,id_jornada from Terapeuta where id_Terapeuta='" + pIdTerapeuta.ToString() + "'", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            if (_reader.Read())
            {


                pTerapeuta.Id = _reader.GetInt32(0);
                pTerapeuta.Apellido = _reader.GetString(3);
                pTerapeuta.Nombre = _reader.GetString(2);
                pTerapeuta.Id_Jornada = _reader.GetInt32(4);


            }

            return pTerapeuta;
        }

        public static List<Especialidad> ObtenerEspecialidad()
        {
            List<Especialidad> _listaEspecialidad = new List<Especialidad>();

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando = new SqlCommand("select id_Especialidad,descripcion from Especialidad", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Especialidad pEspecialidad = new Especialidad();

                pEspecialidad.Id = _reader.GetInt32(0);
                pEspecialidad.Descripcion = _reader.GetString(1);



                _listaEspecialidad.Add(pEspecialidad);
            }

            return _listaEspecialidad;
        }

        public static List<Jornada> ObtenerJornada()
        {
            List<Jornada> _listaJornadas = new List<Jornada>();

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando = new SqlCommand("select id_Jornada,tipo_Jornada from Jornada", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Jornada pJornada = new Jornada();

                pJornada.Id = _reader.GetInt32(0);
                pJornada.tipo_Jornada = _reader.GetString(1);



                _listaJornadas.Add(pJornada);
            }
            return _listaJornadas;
        }


        public static Jornada ObtenerJornadas(Int64 idjornada)
        {

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando = new SqlCommand("select id_Jornada,tipo_Jornada,HoraDesde,HoraHasta from Jornada where id_Jornada = '" + idjornada + "'", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();

            Jornada pJornada = new Jornada();
            if (_reader.Read())
            {

                pJornada = new Jornada(_reader.GetInt32(0), _reader.GetString(1), _reader.GetTimeSpan(2), _reader.GetTimeSpan(3));

            }
            return pJornada;



        }


        internal static Terapeuta ObtenerTerapeuta2(long Id)
        {
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {


                Terapeuta pTerapeuta = new Terapeuta();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select id_Terapeuta,Apellido,Nombre,usuario,contraseña,id_Jornada,id_Especialidad from Terapeuta where id_terapeuta = {0} ",
                    Id), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pTerapeuta.Id = reader.GetInt32(0);
                    pTerapeuta.Apellido = reader.GetString(1);
                    pTerapeuta.Nombre = reader.GetString(2);
                    pTerapeuta.Usuario = reader.GetString(3);
                    pTerapeuta.Contraseña = reader.GetString(4);
                    pTerapeuta.Id_Jornada = reader.GetInt32(5);
                    pTerapeuta.Id_Especialidad = reader.GetInt32(6);






                }
                conexion.Close();
                return pTerapeuta;

            }

        }


        public static List<Terapeuta> ObtenerTerapeutaParaDTGV()
        {
            List<Terapeuta> _listaTerapeutas = new List<Terapeuta>();

            SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand _comando = new SqlCommand("Select id_Terapeuta,Apellido,Nombre,usuario,contraseña,id_Jornada,id_Especialidad from Terapeuta", conexion);
            SqlDataReader reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                Terapeuta pTerapeuta = new Terapeuta();

                pTerapeuta.Id = reader.GetInt32(0);
                pTerapeuta.Apellido = reader.GetString(1);
                pTerapeuta.Nombre = reader.GetString(2);
                pTerapeuta.Usuario = reader.GetString(3);
                pTerapeuta.Contraseña = reader.GetString(4);
                pTerapeuta.Id_Jornada = reader.GetInt32(5);
                pTerapeuta.Id_Especialidad = reader.GetInt32(6);


                _listaTerapeutas.Add(pTerapeuta);
            }

            return _listaTerapeutas;
        }

        public static int ModificarTerapeuta(Terapeuta pTerapeuta)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand
                    (string.Format(
                        "Update Terapeuta set Apellido='{0}', Nombre='{1}', usuario='{2}', contraseña='{3}',id_Jornada={4},id_Especialidad={5} from Terapeuta where id_terapeuta='{6}'",
                        pTerapeuta.Apellido, pTerapeuta.Nombre, pTerapeuta.Usuario, pTerapeuta.Contraseña, pTerapeuta.Id_Jornada, pTerapeuta.Id_Especialidad, pTerapeuta.Id), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }

    }
}