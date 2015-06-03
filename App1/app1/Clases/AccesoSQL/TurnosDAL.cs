using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace App1.Clases.AccesoSQL
{
    class TurnosDAL
    {
      /*  public list<Turno> ObtenerTurnosTerapeuta(Int64 idTerapeuta, DayOfWeek diasSemanas)
        {
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "select id_Turno,id_Paciente,id_TipoTratamiento,Fecha,hora,id_Terapeuta,id_Estado,Motivo from Turno where id_Terapeuta={0}"),
                    idTerapeuta,  conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    DiasNoLaborales pDiasNoLaborales = new DiasNoLaborales();
                    pDiasNoLaborales.Id = reader.GetInt32(0);
                    pDiasNoLaborales.DiaNoLaboral = reader.GetDateTime(1).ToShortDateString();
                    pDiasNoLaborales.IdTerapeuta = reader.GetInt32(2);

                    _listaDiasNoLaboraleses.Add(pDiasNoLaborales);

                }
                return _listaDiasNoLaboraleses;


                conexion.Close();
            }

 
        }*/
        
        
        public static int AgregarTurno(Turno pTurno)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Turno (id_Paciente,id_TipoTratamiento,Fecha,hora,id_Terapeuta,id_Estado,Motivo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                            pTurno.id_Cliente, pTurno.id_Tratamiento, pTurno.Fecha_Tratamiento, pTurno.Hora,
                            pTurno.id_Terapeuta, pTurno.id_Estado, pTurno.Motivo), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }



     /*  public static int GenerarTurnos(Int64 idTerapeuta)
        {
            Terapeuta pepe = TerapeutaDAL.ObtenerTerapeuta(idTerapeuta);
            Jornada horariosdepepe = TerapeutaDAL.ObtenerJornadas(pepe.Id_Jornada);
            List<DayOfWeek> pDias = AgendaDAL.ObtenerListaDias(idTerapeuta);
            

        
        }*/

    }
}
