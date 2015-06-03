using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    class Jornada
    {
        public int Id { get; set; }
        public string tipo_Jornada { get; set; }
        public TimeSpan desde { get; set; }
        public TimeSpan hasta { get; set; }

        public Jornada()
        { }

        public Jornada(int pId, string pTipo_Jornada, TimeSpan desde, TimeSpan hasta)
        {
            this.Id = pId;
            this.tipo_Jornada = pTipo_Jornada;
            this.desde = desde;
            this.hasta = hasta;
            
        }
    
    }
}
