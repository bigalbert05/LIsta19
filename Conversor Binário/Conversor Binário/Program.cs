using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Binário
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor x = new Conversor();
            x.SetNum(int.Parse(Console.ReadLine()));
            Console.WriteLine(x.Binario());
            Console.ReadKey();
        }
    }
}
