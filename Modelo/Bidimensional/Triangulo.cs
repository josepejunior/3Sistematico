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
        public double Base {  get; set; }
        public double Altura { get; set; }
        public double Arista { get; set; }

        public Triangulo(string tipofigura, string especificofigura, double basetrinangulo, double altura, double arista) : base(tipofigura, especificofigura)
        {
            Base = basetrinangulo;
            Altura = altura;
            Arista = arista;
        }

        public override string Area()
        {
            return (Base * Altura / 2).ToString();
        }

        public override string Perimetro()
        {
            return (Arista * Arista * Arista).ToString();
        }
    }
}
