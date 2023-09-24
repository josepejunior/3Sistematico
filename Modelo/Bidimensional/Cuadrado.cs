using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Bidimensional
{
    public class Cuadrado : FiguraBidimensional
    {
        public double Lado { get; set; }

        public Cuadrado(string tipofigura, string especificofigura, double lado) : base(tipofigura, especificofigura)
        {
            Lado = lado;
        }

        // Obteniendo el área
        public override double Area() => Lado * Lado;

        // Obteniendo el perímetro
        public override double Perimetro() => 4 * Lado;

        // Imrimiendo los datos
        public override string ToString() => base.ToString() +
            $"Área: {Area():F2}\n" +
            $"Perímetro: {Perimetro():F2}";
    }
}
