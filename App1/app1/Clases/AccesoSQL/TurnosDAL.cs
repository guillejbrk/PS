using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App1.Clases.AccesoSQL
{
    class TurnosDAL
    {

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
                                 pTurno.Fecha_Tratamiento.ToShortDateString(), pTurno.Hora, pTurno.id_Terapeuta, pTurno.id_Estado, pTurno.Motivo), Conn);

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
            int resultado = 0;

          
           
              
            Terapeuta pepe = TerapeutaDAL.ObtenerTerapeuta(idTerapeuta);
            Jornada horariosdepepe = TerapeutaDAL.ObtenerJornadas(pepe.Id_Jornada);
            List<DayOfWeek> pDias = AgendaDAL.ObtenerListaDias(idTerapeuta);
            List<DiasNoLaborales> pDiasNoLaborales = AgendaDAL.ObtenerDiasNoLaboralesMes(idTerapeuta);

            DateTime FechadelTurno = new DateTime();
            FechadelTurno = DateTime.Today;

            if (!ExisteDiaLaboral(idTerapeuta, FechadelTurno))
                  {
            for (int j = 0; j < 30; j++)
            {

                TimeSpan HoraTurno = horariosdepepe.desde;

                if (pDias.Contains(FechadelTurno.DayOfWeek))
                {
                    for (int i = 0; i < (horariosdepepe.hasta - horariosdepepe.desde).Hours * 2; i++)
                    {

                        Turno pTurno = new Turno(idTerapeuta, FechadelTurno, HoraTurno);
                        TurnosDAL.AgregarTurno(pTurno);
                        HoraTurno = HoraTurno.Add(new TimeSpan(0, 30, 0));
                    }
                }
                FechadelTurno = FechadelTurno.AddDays(1);
              
            }

            MessageBox.Show("Dias Del Mes Generados, Ya puede ingresar Turnos", "Turnos", MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
       

            }
            else
            {
                MessageBox.Show("NO se Puede Cargar Mas Dias!", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            }
            return
               resultado;
           
        }

        public static List<Turno> ObtenerTurnosDelMes(Int64 idTerapeuta, DayOfWeek d)
        {

            
            List<Turno> _listaTurnos = new List<Turno>();

            SqlConnection conexion = BDComun.obtenerConexion();

            DateTime fechaturno = DateTime.Today;
            for (int i = 0; i < 30; i++)
            {

                if (fechaturno.DayOfWeek == d && !AgendaDAL.ExisteNoLaboral(idTerapeuta, fechaturno))
                {
                    SqlCommand comando = new SqlCommand(string.Format(
                        "select id_Turno,Fecha,hora,id_Estado,Motivo from Turno where id_Terapeuta={0} and Fecha = '{1}' and (id_Estado = 3 or id_Estado = 2)",
                            idTerapeuta, fechaturno.ToShortDateString()), conexion);
                    SqlDataReader _reader = comando.ExecuteReader();
                    while (_reader.Read())
                    {
                        Turno pTurno = new Turno();

                        pTurno.Id = _reader.GetInt32(0);
                        pTurno.Fecha_Tratamiento = _reader.GetDateTime(1);
                        pTurno.Hora = _reader.GetTimeSpan(2);
                        pTurno.id_Estado = _reader.GetInt32(3);
                        pTurno.Motivo = _reader.GetString(4);
                        pTurno.id_Terapeuta = idTerapeuta;




                        _listaTurnos.Add(pTurno);
                    }
                    _reader.Close();
                }
                fechaturno = fechaturno.AddDays(1);
            }
            return _listaTurnos;
        }

        internal static void ActualizarTurno(Turno pTurno)
        {
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {


                SqlCommand Comando =
                new SqlCommand(
                    String.Format(
                        "update Turno set id_Paciente = {0}, id_TipoTratamiento = {1}, id_Estado = {5}, Motivo = '{6}'  where Fecha = '{2}' and hora = '{3}' and id_Terapeuta = {4} ",
                        pTurno.id_Cliente, pTurno.id_Tratamiento, pTurno.Fecha_Tratamiento.ToShortDateString(), pTurno.Hora, pTurno.id_Terapeuta, pTurno.id_Estado, pTurno.Motivo), Conn);

                Comando.ExecuteNonQuery();



            }
        }

        public static List<Turno> DiasDeAltaOCancelado(Int64 pIdTerapeuta)
        {
            List<Turno> _listaTurno = new List<Turno>();

            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select Id_Turno,id_Paciente, id_TipoTratamiento,Fecha,hora,id_Terapeuta,id_Estado,Motivo from Turno where id_Terapeuta = {0} and (id_Estado=1 or id_Estado=2) and Fecha between '{1}' and '{2}' ",
                    pIdTerapeuta, DateTime.Now.ToShortDateString(), DateTime.Now.AddDays(365).ToShortDateString()), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Turno pTurnos = new Turno();

                    pTurnos.Id = reader.GetInt32(0);
                    pTurnos.id_Cliente = reader.GetInt32(1);
                    pTurnos.id_Tratamiento = reader.GetInt32(2);
                    pTurnos.Fecha_Tratamiento = reader.GetDateTime(3);
                    pTurnos.Hora = reader.GetTimeSpan(4);
                    pTurnos.id_Terapeuta = reader.GetInt32(5);
                    pTurnos.id_Estado = reader.GetInt32(6);
                    pTurnos.Motivo = reader.GetString(7);

                    _listaTurno.Add(pTurnos);

                }
                return _listaTurno;
                conexion.Close();


            }

        }

        public static bool ExisteDiaLaboral(Int64 idTerapeuta, DateTime fecha)
        {

            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Turno WHERE Id_Terapeuta=@Id_Terapeuta and fecha=@fecha";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("Id_Terapeuta", idTerapeuta);

                cmd.Parameters.AddWithValue("fecha", fecha.ToShortDateString());

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }
        }

        public static List<Turno> DiasDeAltaOCanceladoPorPaciente(Int64 pIdPaciente)
        {
            List<Turno> _listaTurno = new List<Turno>();

            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select Id_Turno,id_Paciente, id_TipoTratamiento,Fecha,hora,id_Terapeuta,id_Estado,Motivo from Turno where id_Paciente = {0} and (id_Estado=1 or id_Estado=2) ",
                    pIdPaciente), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Turno pTurnos = new Turno();

                    pTurnos.Id = reader.GetInt32(0);
                    pTurnos.id_Cliente = reader.GetInt32(1);
                    pTurnos.id_Tratamiento = reader.GetInt32(2);
                    pTurnos.Fecha_Tratamiento = reader.GetDateTime(3);
                    pTurnos.Hora = reader.GetTimeSpan(4);
                    pTurnos.id_Terapeuta = reader.GetInt32(5);
                    pTurnos.id_Estado = reader.GetInt32(6);
                    pTurnos.Motivo = reader.GetString(7);

                    _listaTurno.Add(pTurnos);

                }
                return _listaTurno;
                conexion.Close();


            }

        }

        internal static void ActualizarTurnosCancelar(Turno pTurno)
        {
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {


                SqlCommand Comando =
                new SqlCommand(
                    String.Format(
                        "update Turno set id_Estado = {2}, Motivo = '{1}' where id_Turno={0} ",
                       pTurno.Id,pTurno.Motivo,pTurno.id_Estado), Conn);

                Comando.ExecuteNonQuery();



            }
        }
        
        
        


       

    }
        
  }

