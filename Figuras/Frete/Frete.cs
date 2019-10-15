using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frete
{
    class Frete
    {
        private double p, d;

        public Frete(double p, double d)
        {
            this.p = p;
            this.d = d;
        }
        public virtual double CalcFrete()
        {
            return 0.01 * (p * d);
        }
        public override string ToString()
        {
            return $"{p},{d},{CalcFrete()}";
        }
    }
}
