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
        public Int64 id_Agenda { get; set; }
        public Int64 id_Jornada { get; set; }
        public Int64 id_Especialidad { get; set; }

          public Terapeuta()
        { }

        public Terapeuta(Int64 pId, string pApellido, string pNombre, string pUsuario,string pContraseña,
            Int64 pid_Agenda, Int64 pid_Jornada, Int64 pid_Especialidad)

        {
            this.Id = pId;
            this.Apellido = pApellido;
            this.Nombre = pNombre;
            this.Usuario=pUsuario;
            this.Contraseña=pContraseña;
            this.id_Agenda = pid_Agenda;
            this.id_Jornada = pid_Jornada;
            this.id_Especialidad = pid_Especialidad; 
           
        }
    }
}
