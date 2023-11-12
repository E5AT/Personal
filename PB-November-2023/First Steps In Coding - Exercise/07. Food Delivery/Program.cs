using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegetarian = int.Parse(Console.ReadLine());
            double sumMenu = (chicken * 10.35) + (fish * 12.40) + (vegetarian * 8.15);
            double sumDessert = sumMenu * 0.20;
            Console.WriteLine(sumMenu+sumDessert+2.50);
        }
    }
}
