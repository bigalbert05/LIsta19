using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_utilizando_uma_Lista
{
    class Pilha<T>
    {
        private List<T> lista = new List<T>();

        public int Count()
        {
            return lista.Count;
        }
        public T Top()
        {
            return lista[lista.Count - 1];
        }
        public T Pop()
        {
            T r = lista[lista.Count - 1];
            lista.Remove(r);
            return r;
        }
        public void Push(object t)
        {
            lista.Add(t);
        }
    }
}
