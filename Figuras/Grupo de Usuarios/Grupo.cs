using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_de_Usuarios
{
    class Grupo
    {
        private int w;
        private string descrição;
        private Contato[] contatos = new Contato[10];

        public Grupo(string d)
        {
            descrição = d;
        }
        public void Adicionar(Contato f)
        {
            if (w < 10)
            {
                contatos[w++] = f;
            }
        }
        public Contato[] ListarContato()
        {
            Contato[] atual = new Contato[w];
            Array.Copy(contatos, atual, w);
            return atual;
        }
        public void Excluir(Contato s)
        {
            int m = Array.IndexOf(contatos, s);
            for (int j = m; j < w; j++)
            {
                contatos[m] = contatos[m + 1];
            }
            w--;
        }
        public override string ToString()
        {
            return $"{descrição}";
        }
    }
}
