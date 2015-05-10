using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    public class Historias
    {
        public Int64 Id { get; set; }
        public string fecha { get; set; }
        public string Observacion { get; set; }
        public Int64 id_Cliente { get; set; }


        public Historias()
        { }

        public Historias(Int64 pId, string pFecha, string pObservacion, Int64 pId_Cliente)
        {
            this.Id = pId;
            this.fecha = pFecha;
            this.Observacion = pObservacion;
            this.id_Cliente = pId_Cliente;
        }


    }



}
