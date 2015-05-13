using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    internal class DiasNoLaborales
    {
        public Int64 Id { get; set; }
        public string DiaNoLaboral { get; set; }
        public Int64 IdTerapeuta { get; set; }



        public DiasNoLaborales()
        {
        }

        public DiasNoLaborales(Int64 pId, string pDiaNoLaboral, Int64 pIdTerapeuta)
        {
            this.Id = pId; 
            this.DiaNoLaboral = pDiaNoLaboral;
            this.IdTerapeuta = pIdTerapeuta;
        }

    }
}
