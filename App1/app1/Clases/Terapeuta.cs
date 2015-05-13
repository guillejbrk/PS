using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    class Terapeuta
    {
        public Int64 Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public Int64 Id_Jornada { get; set; }
        public Int64 Id_Especialidad { get; set; }

          public Terapeuta()
        { }

        public Terapeuta(Int64 pId, string pApellido, string pNombre, string pUsuario,string pContraseña,
           Int64 pId_Jornada, Int64 pId_Especialidad)

        {
            this.Id = pId;
            this.Apellido = pApellido;
            this.Nombre = pNombre;
            this.Usuario=pUsuario;
            this.Contraseña=pContraseña;
           
            this.Id_Jornada = pId_Jornada;
            this.Id_Especialidad = pId_Especialidad; 
           
        }
    }
}
