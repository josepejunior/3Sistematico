using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Tridimensional
{
    public class Cubo : FiguraTridimensional
    {
        public double Lado { get; set; }

        public Cubo(string tipofigura, string especificofigura, double lado) : base(tipofigura, especificofigura)
        {
            Lado = lado;
        }

        public override string Area()
        {
            return (6 * (Lado * Lado)).ToString("N2");
        }

        public override string Volumen()
        {
            return (Lado * Lado * Lado).ToString("N2");
        }
    }
}
