using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retanguloApp
{
    class retangulo
    {
        private double b, h;
        public void SetBase(double v)
        {
            if (v > 0) b = v;
        }
        public void SetAltura(double v)
        {
            if (v > 0) h = v;
        }
        public double GetBase() => b;
        public double GetAltura() => h;
        public double CalcArea() => b * h;
        public double CalcDiagon() => Math.Sqrt(Math.Pow(h, 2) + Math.Pow(b, 2));
    }
}
