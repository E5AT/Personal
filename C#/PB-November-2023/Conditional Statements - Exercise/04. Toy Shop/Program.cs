using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double ex = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            double sum = (puzzle * 2.6) + (doll * 3) + (bear * 4.1) + (minion * 8.2) + (truck * 2);
            double otstupka=0;
            int total = puzzle + doll + bear + minion + truck;
            if (total > 50) otstupka = 0.25 * total;
            sum -= otstupka;
            double naem = 0.10 * sum;
            double pecalba = sum - naem;

            if (pecalba > ex) Console.WriteLine($"Yes! {pecalba-ex} lv left.");
            else Console.WriteLine($"Not enough money! {ex-pecalba} lv needed.");
            //not finished
        }
    }
}
