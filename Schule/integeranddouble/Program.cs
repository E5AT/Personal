using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integeranddouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Целочислен тип = int
            int a = 2, b = 4, c = 3;
            int a1, b1, c1;
            a1 = a + b - c;
            b1 = b * c;
            c1 = b / a;
            //Дробни числа = double
            double a2 = 2.3;
            Console.WriteLine(a1);
            Console.WriteLine(b1);
            Console.WriteLine(c1);
            Console.WriteLine(a1 + b1);
            Console.WriteLine(b1 * c1);
            Console.WriteLine(b / c);
            Console.WriteLine(a2);
            Console.WriteLine(a2 + 2);
            Console.Read();
        }
    }
}