using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{
    class Poupança: ContaCorrente
    {
        public Poupança(string titular, string numerodaconta) : base(titular, numerodaconta)
        {

        }
        public void Render(double juros)
        {
            base.saldo = base.saldo + juros * base.saldo;
        }
    }
}
