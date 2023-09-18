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

        public override string Area()
        {
            return (4 * Math.PI * Radio * Radio).ToString();
        }

        public override string Volumen()
        {
            return (1.33 * Math.PI * Radio * Radio * Radio).ToString();
        }
    }
}
