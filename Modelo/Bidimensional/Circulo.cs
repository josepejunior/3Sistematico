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

        public override string Area()
        {
            return (Math.PI * Radio * Radio).ToString();
        }

        public override string Perimetro()
        {
            return (2 * Math.PI * Radio).ToString();
        }
    }
}
