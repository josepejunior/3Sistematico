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

        public override string Area()
        {
            return (Lado * Lado).ToString("N2");
        }

        public override string Perimetro()
        {
            return (4 * Lado).ToString("N2");
        }
    }
}
