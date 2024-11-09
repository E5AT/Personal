using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(guc(1));
            Console.WriteLine(guc(1.5));
            Console.WriteLine(guc(2));
            Console.WriteLine(guc(2.5));
            Console.WriteLine(guc(3));
            Console.WriteLine(guc(3.5));
            Console.WriteLine(guc(4));
            Console.WriteLine(guc(4.5));
            Console.WriteLine(guc(5));
            Console.WriteLine(guc(5.5));
            Console.WriteLine(guc(6));
            Console.WriteLine(guc(6.5));
            Console.WriteLine(guc(7));
            Console.WriteLine(guc(7.5));
            Console.WriteLine(guc(8));
            Console.WriteLine(guc(8.5));
            Console.WriteLine(guc(9));
            Console.WriteLine(guc(9.5));
            Console.WriteLine(guc(10));

            Console.ReadKey();
        }
        static int guc(int sayi)
        {
            return sayi * sayi;
        }

        static double guc(double sayi)
        {
            return sayi * sayi;
        }
    }
}