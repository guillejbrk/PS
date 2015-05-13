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
        public string Franja_Horaria { get; set; }

          public Jornada()
        { }

        public Jornada(int pId, string pTipo_Jornada, string pFranja_Horaria)
        {
            this.Id = pId;
            this.tipo_Jornada = pTipo_Jornada;
            this.Franja_Horaria = pFranja_Horaria;
            
        }
    
    }
}
