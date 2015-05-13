using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    class Agenda
    {
         public Int64 Id { get; set; }
        public Boolean Lunes { get; set; }
        public Boolean Martes { get; set; }
        public Boolean Miercoles { get; set; }
        public Boolean Jueves { get; set; }
        public Boolean Viernes { get; set; }
        public Boolean Sabado { get; set; }
        public Boolean Domingo { get; set; }
        public Int64 IdTerapeuta { get; set; }

        public Agenda()
        { }

        public Agenda(Int64 pId, Boolean pLunes, Boolean pMartes, Boolean pMiercoles, Boolean pJueves, Boolean pViernes, Boolean pSabado, Boolean pDomingo, Int64 pIdTerapeuta)
        {
            this.Id = pId;
            this.Lunes = pLunes;
            this.Martes = pMartes;
            this.Miercoles = pMiercoles;
            this.Jueves = pJueves;
            this.Viernes = pViernes;
            this.Sabado = pSabado;
            this.Domingo = pDomingo;
            this.IdTerapeuta = pIdTerapeuta;


        }
    }
}
