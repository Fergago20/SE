using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosPers
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public float Peso { get; set; }
        public float Estatura { get; set; }
        public bool Sexo { get; set; }
        public DateTime Nacimiento {get; set;}
        public int EdadDias()
        {
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual - Nacimiento;
            return (int)diferencia.TotalDays;
        }
    }
}
