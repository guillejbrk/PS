using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    class Especialidad
    {
             public Int64 Id { get; set; }
        public string Descripcion { get; set; }
        
          public Especialidad()
        { }

        public Especialidad(Int64 pId, string pDescripcion)
        {
            this.Id = pId;
            this.Descripcion = pDescripcion;
        
            
        }
    }
}
