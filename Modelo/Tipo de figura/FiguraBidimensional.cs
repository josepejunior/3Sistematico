using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class FiguraBidimensional : Figura
    {
        public string EspecificoFigura {  get; set; }

        public FiguraBidimensional(string tipofigura, string especificofigura) : base(tipofigura)
        {
            EspecificoFigura = especificofigura;
        }

        public abstract string Area();
        public abstract string Perimetro();
    }
}
