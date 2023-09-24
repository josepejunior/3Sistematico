using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Bidimensional
{
    public class Triangulo : FiguraBidimensional
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Arista { get; set; }

        public Triangulo(string tipofigura, string especificofigura, double basetrinangulo, double altura, double arista) : base(tipofigura, especificofigura)
        {
            Base = basetrinangulo;
            Altura = altura;
            Arista = arista;
        }

        // Obteniendo el área
        public override double Area() => Base * Altura / 2;

        // Obteniendo el perímetro
        public override double Perimetro() => Arista + Arista + Arista;

        // Imrimiendo los datos
        public override string ToString() => base.ToString() +
            $"Área: {Area():F2}\n" +
            $"Perímetro: {Perimetro():F2}";
    }
}
