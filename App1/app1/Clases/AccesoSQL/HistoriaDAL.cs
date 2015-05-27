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
                            pHistorias.fecha, pHistorias.Observacion, pHistorias.id_Cliente), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
