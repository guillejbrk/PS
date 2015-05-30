using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    class Producto
    {
             public Int64 Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public Int64 Cantidad { get; set; }
        public Int64 id_Terapeuta { get; set; }

          public Producto()
                    { }

        public Producto(Int64 pId, string pDescripcion, decimal pCosto, Int64 pCantidad, Int64 pIdTerapeuta)
        {
            this.Id = pId;
            this.Descripcion = pDescripcion;
            this.Costo = pCosto;
            this.Cantidad = pCantidad;
            this.id_Terapeuta = pIdTerapeuta;
            
        }
    }
}
