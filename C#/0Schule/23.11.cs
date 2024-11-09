using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._11
{
    class Program
    {
        static void printHeader()
        {
            Console.WriteLine("Cash Receipt");
            Console.WriteLine("---------------------------");
        }

        static void printBody()
        {
            Console.WriteLine("Charged to:................");
        }

        static void printFooter()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("(c) SoftUni");
        }

        static void print()
        {
            printHeader();
            printBody();
            printFooter();
        }

        static void Main(string[] args)
        {
            print();
            Console.ReadLine();
        }
    }
}
