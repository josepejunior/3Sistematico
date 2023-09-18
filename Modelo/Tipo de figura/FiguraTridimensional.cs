using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class FiguraTridimensional : Figura
    {
        public string EspecificoFigura { get; set; }

        public FiguraTridimensional(string tipofigura, string especificofigura) : base(tipofigura)
        {
            EspecificoFigura = especificofigura;
        }

        public abstract string Area();
        public abstract string Volumen();
    }
}
