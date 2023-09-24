using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    // Clase abstracta por los métodos no implementados
    public abstract class FiguraTridimensional : Figura
    {
        public string EspecificoFigura { get; set; }

        public FiguraTridimensional(string tipofigura, string especificofigura) : base(tipofigura)
        {
            EspecificoFigura = especificofigura;
        }

        public abstract double Area(); // Método para obtener el área de la figura

        public abstract double Volumen(); // Método para obtener el volumen de la figura

        // Imprime los datos de la figura
        public override string ToString() =>
            $"Cálculos de la figura {EspecificoFigura} de tipo {TipoFigura}\n";
    }
}
