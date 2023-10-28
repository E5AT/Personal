using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double garden = double.Parse(Console.ReadLine());
            double price = garden * 7.61;
            double discount = price * 0.18;
            price = price - discount;
            Console.WriteLine($"The final price is: {price} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
