using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    public class Historias
    {
        public Int64 Id { get; set; }
        public string Fecha { get; set; }
        public string Observacion { get; set; }
        public Int64 idPaciente { get; set; }


        public Historias()
        { }

        public Historias(Int64 pId, string pFecha, string pObservacion, Int64 pIdPaciente)
        {
            this.Id = pId;
            this.Fecha = pFecha;
            this.Observacion = pObservacion;
            this.idPaciente = pIdPaciente;
        }


    }



}
