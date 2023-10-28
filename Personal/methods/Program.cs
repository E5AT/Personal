using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ur name: ");
            string name = Console.ReadLine();
            Console.Write("Enter ur age: ");
            int age = int.Parse(Console.ReadLine());
            string answer;
            do
            {
                Console.Write("(l)ong or (s)hort: ");
                answer = Console.ReadLine();
            }
            while (answer != "l" && answer != "s");
            bool longg = (answer == "l") ? true : false;
            Console.WriteLine();

            bDay(name, age, longg);

            Console.ReadKey();
        }
        static void bDay(string name, int age, bool longg)
        {
            if (longg == true)
            {
                for (int i = 1; i <= age; i++)
                {
                    Console.WriteLine($"{i}. Happy birthday {name}!");
                }
            }
            else
            {
                Console.WriteLine($"Happy birthday {name}, {age} times!");
            }
        }
    }
}