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

        // Obteniendo el área
        public override double Area() => 1.73 * Arista * Arista;

        // Obteniendo el volumen
        public override double Volumen() => (Arista * Arista * Arista * 1.42) * 0.5;

        // Imrimiendo los datos
        public override string ToString() => base.ToString() +
            $"Área: {Area():F2}\n" +
            $"Volumen: {Volumen():F2}";
    }
}
