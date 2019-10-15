using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Retangulo
    {
        private double b;
        private double h;

        public Retangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public double Getbase()
        {
            return b;
        }
        public double GetAltura()
        {
            return h;
        }
        public double CalcArea()
        {

            return b * h;
        }
        public double CalcDiagonal()
        {
            return Math.Sqrt((b * b) + (h * h));
        }
        public override string ToString()
        {
            return $"{b} - {h} - {CalcArea()} - {CalcDiagonal()}";
        }
    }
}
