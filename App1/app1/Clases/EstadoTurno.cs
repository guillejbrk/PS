using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    class EstadoTurno
    {
             public Int64 Id { get; set; }
        public string Estado { get; set; }
      
          public EstadoTurno()
        { }

        public EstadoTurno(Int64 pId, string pEstado, string pMotivo)
        {
            this.Id = pId;
            this.Estado = pEstado;
           
            
        }
    }
}
