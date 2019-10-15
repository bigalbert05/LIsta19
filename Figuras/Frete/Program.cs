using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frete
{
    class Program
    {
        static void Main(string[] args)
        {
            Frete x = new Frete(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(x.CalcFrete());

            FreteExpresso y = new FreteExpresso(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(y.CalcFrete());
        }
    }
}
