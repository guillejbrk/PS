using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace App1.Clases.AccesoSQL
{
    internal class AgendaDAL
    {
        public static int AgregarDia(Agenda pAgenda)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Agenda (Lunes,Martes,Miercoles,Jueves,Viernes,Sabado,Domingo, id_Terapeuta) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                            pAgenda.Lunes, pAgenda.Martes, pAgenda.Miercoles, pAgenda.Jueves, pAgenda.Viernes,
                            pAgenda.Sabado, pAgenda.Domingo, pAgenda.IdTerapeuta), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;



        }

        public static Agenda ObtenerAgenda(Int64 pIdTerapeuta)
        {

            using (SqlConnection conexion = BDComun.obtenerConexion())
            {

                Agenda pAgenda = new Agenda();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select id_Agenda, Lunes, Martes ,Miercoles , Jueves , Viernes ,Sabado ,Domingo ,id_Terapeuta from Agenda where id_Terapeuta = {0} ",
                    pIdTerapeuta), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pAgenda.Id = reader.GetInt32(0);
                    pAgenda.Lunes = reader.GetBoolean(1);
                    pAgenda.Martes = reader.GetBoolean(2);
                    pAgenda.Miercoles = reader.GetBoolean(3);
                    pAgenda.Jueves = reader.GetBoolean(4);
                    pAgenda.Viernes = reader.GetBoolean(5);
                    pAgenda.Sabado = reader.GetBoolean(6);
                    pAgenda.Domingo = reader.GetBoolean(7);
                    pAgenda.IdTerapeuta = reader.GetInt32(8);


                }
                conexion.Close();
                return pAgenda;

            }



        }

        public static bool Existe(int id)
        {

            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Agenda WHERE Id_Terapeuta=@Id_Terapeuta";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("Id_Terapeuta", id);


                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }
        }

        public static int ModificarAgenda(Agenda pAgenda)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand
                    (string.Format(
                        "Update Agenda set Lunes='{0}', Martes='{1}', Miercoles='{2}', Jueves='{3}', Viernes='{4}', Sabado='{5}',Domingo='{6}' where id_Terapeuta={7}",
                        pAgenda.Lunes, pAgenda.Martes, pAgenda.Miercoles, pAgenda.Jueves, pAgenda.Viernes,
                        pAgenda.Sabado, pAgenda.Domingo, pAgenda.IdTerapeuta), conexion);



                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }

        public static int AgregarDiaNoLaboral(DiasNoLaborales pDiasNoLaborales)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Dias_NoLaborales (Dia_NoLaboral,id_Terapeuta) values ('{0}','{1}')",
                           pDiasNoLaborales.DiaNoLaboral, pDiasNoLaborales.IdTerapeuta), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;


        }



        public static bool DiaLaboralExiste(int var, string var1)
        {

            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                string query = "SELECT count(*) FROM Dias_NoLaborales" +
                               " WHERE dia_NoLaboral= @dia_NoLaboral and id_Terapeuta=@id_Terapeuta";
                SqlCommand cmd = new SqlCommand(query, conexion);
              
                cmd.Parameters.AddWithValue("id_Terapeuta", var);
                cmd.Parameters.AddWithValue("dia_NoLaboral", var1);


                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }
        }


    }
}
