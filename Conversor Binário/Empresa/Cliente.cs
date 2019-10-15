using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Cliente
    {
        private string nome { get; set; }
        private string cpf { get; set; }
        private double limite;
        private List<Cliente> socio = new List<Cliente>();

        public double LimiteTotal
        {
            get
            {
                double lt = 0;
                foreach (Cliente i in socio)
                {
                    lt += i.limite;
                }
                return lt;
            }
        }

        public Cliente(string n, string c, double l)
        {
            nome = n;
            cpf = c;
            limite = l;
        }
        public void Inserir(Cliente c)
        {
            socio.Add(c);
        }
        public void Excluir(Cliente c)
        {
            socio.Remove(c);
        }
        public bool socios()
        {
            if (socio == null) return true;
            return false;
        }
    }
}
