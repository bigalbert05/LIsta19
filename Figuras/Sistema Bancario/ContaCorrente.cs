using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{
    class ContaCorrente
    {
        private string titular, numerodaconta;
        protected double saldo;

        public ContaCorrente(string t, string n)
        {
            titular = t;
            numerodaconta = n;
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public virtual bool Sacar(double valor)
        {
            if (valor > saldo) return false;
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public double RetornarSaldo()
        {
            return saldo;
        }

        public override string ToString()
        {
            return $"{titular} - {numerodaconta} - {saldo}";
        }
    }
}
