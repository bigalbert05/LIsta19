using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtora
{
    class Motorista : Funcionario
    {
        private string cnh;

        public void SetCnh(string h)
        {
            cnh = h;
        }
        public string GetCnh()
        {
            return cnh;
        }
        public override string ToString()
        {
            return $"{GetNome()} - {GetEmail()} - {GetFone()} - {cnh}";
        }
    }
}
