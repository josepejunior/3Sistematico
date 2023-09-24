using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Tridimensional
{
    public class Esfera : FiguraTridimensional
    {
        public double Radio { get; set; }

        public Esfera(string tipofigura, string especificofigura, double radio) : base(tipofigura, especificofigura)
        {
            Radio = radio;
        }

        // Obteniendo el área
        public override double Area() => 4 * Math.PI * Radio * Radio;

        // Obteniendo el volumen
        public override double Volumen() => 1.33 * Math.PI * Radio * Radio * Radio;

        // Imrimiendo los datos
        public override string ToString() => base.ToString() +
            $"Área: {Area():F2}\n" +
            $"Volumen: {Volumen():F2}";
    }
}
