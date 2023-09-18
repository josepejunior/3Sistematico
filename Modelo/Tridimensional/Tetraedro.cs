using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Tridimensional
{
    public class Tetraedro : FiguraTridimensional
    {
        public double Arista { get; set; }

        public Tetraedro(string tipofigura, string especificofigura, double arista) : base(tipofigura, especificofigura)
        {
            Arista = arista;
        }

        public override string Area()
        {
            return (1.73 * Arista * Arista).ToString();
        }

        public override string Volumen()
        {
            return (0.28 * Arista * Arista * Arista).ToString();
        }
    }
}
