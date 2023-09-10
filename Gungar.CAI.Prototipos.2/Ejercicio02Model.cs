using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._2
{
    internal class Ejercicio02Model
    {
        public string NombreUsuario { get; } = "Gungar";
        public string NombreReal { get; } = "Guido Ungar";

        public string[] Marcas { get; set; } = new string[] { "Ford", "Fiat", "Chevrolet", "Audi" };
        public string? ModeloIngresado { get; set; }
        public string? AnoIngresado { get; set; }
        public string? PrecioIngresado { get; set; }
        public string? MarcaIngresada { get; set; }


        public string Validar()
        {
            // Validar y responder un texto de error si hay error, si no un Ok

            return "Ok";
        }
    }
}
