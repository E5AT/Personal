using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._2
{
    public class Triangle
    {
        public int a, b, c, h, P;
        public double S;

        public int calcP()
        {
            return this.a + this.b + this.c;
        }

        public double calcS()
        {
            return (this.a * this.h) / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.Write("a = "); triangle.a = int.Parse(Console.ReadLine());
            Console.Write("b = "); triangle.b = int.Parse(Console.ReadLine());
            Console.Write("c = "); triangle.c = int.Parse(Console.ReadLine());
            Console.Write("h = "); triangle.h = int.Parse(Console.ReadLine());

            double P = triangle.calcP();
            double S = triangle.calcS();

            Console.WriteLine("P = " + P + " cm");
            Console.WriteLine("S = " + S + " cm2");
        }

        
    }
}
