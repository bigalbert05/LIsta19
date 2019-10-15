using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Quadrado:Retangulo
    {
        public Quadrado(double i) : base(i, i)
        {

        }
        public override string ToString()
        {
            return $"{base.Getbase()} - {CalcArea()} - {CalcDiagonal()}";
        }
    }
}
