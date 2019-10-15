using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frete
{
    class FreteExpresso:Frete
    {
        private double seguro;

        public FreteExpresso(double p, double d, double s) : base(p, d)
        {
            seguro = s;
        }
        public override double CalcFrete()
        {
            return (2 * base.CalcFrete() + (0.01 * seguro));
        }
        public override string ToString()
        {
            return $"{seguro},{CalcFrete()}";
        }
    }
}
