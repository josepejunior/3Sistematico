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

        // Obteniendo el área
        public override double Area() => 6 * (Lado * Lado);

        // Obteniendo el volumen
        public override double Volumen() => Lado * Lado * Lado;

        // Imrimiendo los datos
        public override string ToString() => base.ToString() +
            $"Área: {Area():F2}\n" +
            $"Volumen: {Volumen():F2}";
    }
}
