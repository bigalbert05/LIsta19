using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Binário
{
    class Conversor
    {
        private int num;
        private Stack<int> pilha = new Stack<int>();

        public void SetNum(int n)
        {
            num = n;
        }
        public string Binario()
        {
            string vazia = "";
            int a = num, comp = 0;
            while (a > 1)
            {
                pilha.Push(a % 2);
                a = a / 2;
                comp++;
            }
            while (comp-- > 0)
            {
                vazia = vazia + (pilha.Pop()).ToString();
            }
            return vazia;
        }
    }
}
