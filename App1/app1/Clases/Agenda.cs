using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    class Agenda
    {
             public Int64 Id { get; set; }
        public string Dia { get; set; }
       

          public Agenda()
        { }

        public Agenda(Int64 pId, string pDia)
        {
            this.Id = pId;
            this.Dia = pDia;
         
            
        }
    }
}
