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
                            pTerapeuta.Id_Jornada,pTerapeuta.Id_Especialidad), Conn);

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

        public static List<Jornada> ObtenerJornadas()
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
    }
}
