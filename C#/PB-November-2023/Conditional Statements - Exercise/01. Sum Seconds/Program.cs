using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int total = a + b + c;
            int min = total / 60;
            int sec = total % 60;
            if (sec < 10) Console.WriteLine($"{min}:0{sec}");
            else Console.WriteLine($"{min}:{sec}");
        }
    }
}
