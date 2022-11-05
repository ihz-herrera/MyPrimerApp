using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Clases
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
