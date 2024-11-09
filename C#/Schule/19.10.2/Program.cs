using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int S;
            Console.Write("Въведи число: ");
            S = Convert.ToInt32(Console.Read());
            if (S % 2 == 0)
            {
                Console.WriteLine("Числото е четно!");
            }
            else
            {
                Console.WriteLine("Числото е нечетно!");
            }

            Console.ReadKey();
        }
    }
}
