using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Bidimensional
{
    public class Circulo : FiguraBidimensional
    {
        public double Radio { get; set; }

        public Circulo(string tipofigura, string especificofigura, double radio) : base(tipofigura, especificofigura)
        {
            Radio = radio;
        }

        // Obteniendo el área
        public override double Area() => Math.PI * Radio * Radio;

        // Obteniendo el perímetro
        public override double Perimetro() => 2 * Math.PI * Radio;

        // Imrimiendo los datos
        public override string ToString() => base.ToString() + 
            $"Área: {Area():F2}\n" +
            $"Perímetro: {Perimetro():F2}";
    }
}
