using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{

    /// <summary>
    /// Cliente 
    /// </summary>
    public class Cliente
    {
        public Int64 Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public Int64 Edad { get; set; }
        public string Fecha { get; set; }
        public string Domicilio { get; set; }
        public string Tel { get; set; }
        public string Cel { get; set; }
        public string Correo { get; set; }
       


        public Cliente()
        {
            

        }

        public Cliente( Int64 pId, string pApellido, string pNombre, Int64 pEdad, string pFecha,string pDomicilio, string pTel, string pCel,
            string pCorreo)

        {
            this.Id = pId;
            this.Apellido = pApellido;
            this.Nombre = pNombre;
            this.Edad = pEdad;
            this.Fecha = pFecha;
            this.Domicilio = pDomicilio;
            this.Tel = pTel;
            this.Cel = pCel;
            this.Correo = pCorreo;


        }

        override public string ToString()
        {
            return Id + "," + Apellido;
        }
      
    }
    }

