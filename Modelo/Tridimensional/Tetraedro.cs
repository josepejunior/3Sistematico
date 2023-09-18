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
            return (Arista * Arista * 1.73).ToString();
        }

        public override string Volumen()
        {
            return (Arista * Arista * Arista * 0.14).ToString();
        }
    }
}
