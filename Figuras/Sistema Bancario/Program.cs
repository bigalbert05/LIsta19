using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente x = new ContaCorrente(Console.ReadLine(), Console.ReadLine());
            x.Depositar(1000);
            x.Sacar(500);
            Console.WriteLine(x.RetornarSaldo());
        }
    }
}
