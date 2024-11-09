using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = "); int a = int.Parse(Console.ReadLine());
            Console.Write("b = "); int b = int.Parse(Console.ReadLine());
            Console.Write("c = "); int c = int.Parse(Console.ReadLine());
            Console.Write("h = "); int h = int.Parse(Console.ReadLine());

            double P = calcP(a, b, c);
            double S = calcS(a, h);

            Console.WriteLine("P = " + P + " cm");
            Console.WriteLine("S = " + S + " cm2");
        }

        static int calcP(int a, int b, int c)
        {
            return a + b + c;
        }

        static double calcS(int a,int h)
        {
            return (a * h) / 2;
        }
    }
}
