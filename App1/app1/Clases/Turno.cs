using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Clases
{
    class Turno
    {
        public Int64 Id { get; set; }
        public Int64 id_Cliente { get; set; }
        public Int64 id_Tratamiento {get;set;}
        public DateTime Fecha_Tratamiento { get; set; }
        public TimeSpan Hora { get; set; }
        public Int64 id_Terapeuta {get;set; }
        public Int64 id_Estado { get; set; }
        public string Motivo { get; set; }

        public Turno()
        {}


        public Turno(Int64 pId, Int64 pid_Cliente, Int64 pid_Tratamiento,
            DateTime pFecha_Tratamiento, TimeSpan pHora, Int64 pId_Terapeuta, Int64 pId_Estado, string pMotivo)

        {
            this.Id = pId;
            this.id_Cliente = pid_Cliente;
            this.id_Tratamiento = pid_Tratamiento;
            this.Fecha_Tratamiento = pFecha_Tratamiento;
            this.Hora = pHora;
            this.id_Terapeuta = pId_Terapeuta;
            this.id_Estado = pId_Estado;
            this.Motivo = pMotivo;

        }
        public Turno(Int64 pId_Terapeuta, DateTime pFecha_Tratamiento, TimeSpan pHora)
        {

           
            this.Fecha_Tratamiento = pFecha_Tratamiento;
            this.Hora = pHora;
            this.id_Terapeuta = pId_Terapeuta;
            this.id_Estado = 3;

            

        }
    }
}
