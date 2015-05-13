using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    class Especialidad
    {
             public int Id { get; set; }
        public string Descripcion { get; set; }
        
          public Especialidad()
        { }

        public Especialidad(int pId, string pDescripcion)
        {
            this.Id = pId;
            this.Descripcion = pDescripcion;
        
            
        }
    }
}
