using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(x.CalcArea());
            Console.WriteLine(x.CalcDiagonal());

            Quadrado y = new Quadrado(double.Parse(Console.ReadLine()));
            Console.WriteLine(y.CalcArea());
            Console.WriteLine(y.CalcDiagonal());
        }
    }
}
