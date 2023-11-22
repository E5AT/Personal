using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 15;

            if (min >= 60)
            {
                hour++;
                min -= 60;
            }

            if (hour >= 24) hour = 0;

            if (min < 10) Console.WriteLine($"{hour}:0{min}");
            else Console.WriteLine($"{hour}:{min}");
        }
    }
}
