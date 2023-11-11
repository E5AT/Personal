using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int pencil = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int preparat = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double final = ((pencil * 5.80) + (marker * 7.20) + (preparat * 1.20));
            Console.WriteLine(final-(final* (discount * 0.01)));
        }
    }
}
