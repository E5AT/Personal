using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._11._1
{
    class Program
    {
        static void printNum(int a,int b)
        {
            for (int i = a; i <= b; i++) Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            printNum(1, 10);
            Console.ReadLine();
        }
    }
}
