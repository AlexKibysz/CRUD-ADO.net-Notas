using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Notas
    {
        public DateTime fechaEntrega { get; set; }

        public DateTime fechaEscritura { get; set; }

        public string mensaje { get; set; }

        public int idNotas { get; set; }
    }
}