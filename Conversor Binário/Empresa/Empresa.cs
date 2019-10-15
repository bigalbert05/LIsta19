using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Empresa
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void Inserir(Cliente c)
        {
            clientes.Add(c);
        }
        public void Excluir(Cliente c)
        {
            clientes.Remove(c);
        }
        public void Socio(Cliente x, Cliente y)
        {
            x.Inserir(y);
            y.Inserir(x);
        }
        public List<Cliente> ListarNaoSocio()
        {
            List<Cliente> nn = new List<Cliente>();
            foreach (Cliente aa in clientes)
            {
                if (aa.socios()) nn.Add(aa);
            }
            return nn;
        }
    }
}
