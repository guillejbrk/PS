using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    public class Tratamiento
    {
        public Int64 Id { get; set; }
        public string Descripcion { get; set; }
        public Int64 IdProducto { get; set; }
        public decimal Costo { get; set; }


        public Tratamiento()
        { }

        public Tratamiento(Int64 pId, string pDescripcion,Int64 pId_Producto, decimal pCosto)
        {
            this.Id = pId;
            this.Descripcion = pDescripcion;
            this.IdProducto = pId_Producto;
            this.Costo = pCosto;


        }


    }
}
