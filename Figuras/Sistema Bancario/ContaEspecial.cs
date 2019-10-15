using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{
    class ContaEspecial: ContaCorrente
    {
        private double limite;

        public ContaEspecial(string titular, string numerodaconta, double l) : base(titular, numerodaconta)
        {
            limite = l;
        }
        public override bool Sacar(double valor)
        {
            if (valor > limite + saldo) return false;

            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
    }
}
