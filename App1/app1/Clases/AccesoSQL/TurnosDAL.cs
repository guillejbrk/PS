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

                if (pTurno.id_Tratamiento == 0)
                {                   

                    SqlCommand Comando =
                        new SqlCommand(
                            String.Format(
                                "insert into Turno (Fecha,hora,id_Terapeuta,id_Estado,Motivo) values ('{0}','{1}','{2}','{3}','{4}')",
                                 pTurno.Fecha_Tratamiento.ToShortDateString(), pTurno.Hora,pTurno.id_Terapeuta, pTurno.id_Estado, pTurno.Motivo), Conn);

                    retorno = Comando.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand Comando =
                    new SqlCommand(
                        String.Format(
                            "insert into Turno (id_Paciente,id_TipoTratamiento,Fecha,hora,id_Terapeuta,id_Estado,Motivo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                            pTurno.id_Cliente, pTurno.id_Tratamiento, pTurno.Fecha_Tratamiento.ToShortDateString(), pTurno.Hora, pTurno.id_Terapeuta, pTurno.id_Estado, pTurno.Motivo), Conn);

                    retorno = Comando.ExecuteNonQuery();

                }
                return retorno;
            }
        }



      public static int GenerarTurnos(Int64 idTerapeuta)
        {

            Terapeuta pepe = TerapeutaDAL.ObtenerTerapeuta(idTerapeuta);
            Jornada horariosdepepe = TerapeutaDAL.ObtenerJornadas(pepe.Id_Jornada);
            List<DayOfWeek> pDias = AgendaDAL.ObtenerListaDias(idTerapeuta);
            List<DiasNoLaborales>pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesMes(idTerapeuta);

            DateTime FechadelTurno = new DateTime();
            FechadelTurno = DateTime.Today;
            
            for (int j = 0; j < 30; j++)
            {

                TimeSpan HoraTurno = horariosdepepe.desde;

                for (int i = 0; i < (horariosdepepe.hasta - horariosdepepe.desde).Hours * 2; i++)
                {

                    Turno pTurno = new Turno(idTerapeuta, FechadelTurno, HoraTurno);
                    TurnosDAL.AgregarTurno(pTurno);
                    HoraTurno = HoraTurno.Add(new TimeSpan(0, 30, 0));
                }
                FechadelTurno = FechadelTurno.AddDays(1);
            }

            return 0;



        
        }

        /* public static bool ExisteDiaNoLaboral(Int64 pID, string pFecha)
         {
 
         }*/

         public static List<Turno> ObtenerTurnosDelMes(Int64 idTerapeuta)
         {
                List<Turno> _listaTurnos= new List<Turno>();

              SqlConnection conexion = BDComun.obtenerConexion();

            SqlCommand comando = new SqlCommand(string.Format(
                "select id_Turno,Fecha,hora,id_Estado,Motivo from Turno where id_Terapeuta={0}",
                    idTerapeuta), conexion);
            SqlDataReader _reader = comando.ExecuteReader();
            while (_reader.Read())
            {
                Turno pTurno = new Turno();

                pTurno.Id=_reader.GetInt32(0);
                pTurno.Fecha_Tratamiento = _reader.GetDateTime(1);
                pTurno.Hora = _reader.GetTimeSpan(2);              
                pTurno.id_Estado=_reader.GetInt32(3);
                pTurno.Motivo=_reader.GetString(4);               
                
                


                _listaTurnos.Add(pTurno);
            }

            return _listaTurnos;
        }
               
    }
    
        
  }

