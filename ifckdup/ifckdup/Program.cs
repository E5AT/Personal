using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifckdup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("База: "); int _base = int.Parse(Console.ReadLine());
            Console.Write("От 1 до :"); int times = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Umnojenie(_base, times);
        }

        //processes
        static void Umnojenie(int _base, int times)
        {
            for (int i = 1; i <= times; i++) Console.WriteLine($"{_base} * {i} = {_base*i}");
        }
    }
}
