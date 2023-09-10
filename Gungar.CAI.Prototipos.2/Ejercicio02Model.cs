using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._2
{
    internal class Ejercicio02Model
    {
        const string comboNoSeleccionado = "Por favor seleccione una opción para";
        const string textoIncompleto = "Por favor ingrese un valor para";


        public string NombreUsuario { get; } = "Gungar";
        public string NombreReal { get; } = "Guido Ungar";

        public string[] Marcas { get; set; } = new string[] { "Ford", "Fiat", "Chevrolet", "Audi" };
        public string? ModeloIngresado { get; set; }
        public string? AnoIngresado { get; set; }
        public string? PrecioIngresado { get; set; }
        public string? MarcaIngresada { get; set; }


        public string Validar()
        {
            if (String.IsNullOrEmpty(MarcaIngresada))
            {
                return comboNoSeleccionado + " la marca";
            }
            if (String.IsNullOrEmpty(ModeloIngresado))
            {
                return textoIncompleto + " el modelo";
            }
            if (String.IsNullOrEmpty(AnoIngresado))
            {
                return textoIncompleto + " el año";
            }
            if (String.IsNullOrEmpty(PrecioIngresado))
            {
                return textoIncompleto + " el precio";
            }


            return "Ok";
        }
    }
}
