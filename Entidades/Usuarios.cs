using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Usuarios
    {
        public string nombre { get; set; }
        public string Apellido { get; set; }

        public int edad { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}