using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_de_Usuarios
{
    class Usuario:Contato
    {
        private int k, h;
        private Contato[] contatos = new Contato[10];
        private Grupo[] grupos = new Grupo[10];

        public Usuario(string n, string f) : base(n, f)
        {

        }
        public void Inserircontatos(Contato c)
        {
            if (k < 10)
            {
                contatos[k++] = c;
            }
        }
        public Contato[] Listarcontatos()
        {
            Contato[] novo = new Contato[k];
            Array.Copy(contatos, novo, k);
            return novo;
        }
        public void Inserirgrupos(Grupo g)
        {
            if (h > 10)
            {
                grupos[h++] = g;
            }
        }
        public Grupo[] Listargrupos()
        {
            Grupo[] recente = new Grupo[h];
            Array.Copy(grupos, recente, h);
            return recente;
        }

        public override string ToString()
        {
            return $"{k} - {h}";
        }
    }
}
