using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtora
{
    class Funcionario
    {
        private string nome, email, fone;

        public void SetNome(string n)
        {
            nome = n;
        }
        public void SetEmail(string e)
        {
            email = e;
        }
        public void SetFone(string f)
        {
            fone = f;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetEmail()
        {
            return email;
        }
        public string GetFone()
        {
            return fone;
        }
        public override string ToString()
        {
            return $"{nome} {email} {fone}";
        }
    }
}
