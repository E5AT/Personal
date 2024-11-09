using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0prj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Operation: ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Math math = new Math(num1, num2, op);

            Console.WriteLine("\nThanks for using The Calculator!");
            Console.ReadLine();
        }
    }
}
