using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,num;
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "square":
                    a = double.Parse(Console.ReadLine());
                    num = a * a;
                    break;

                case "rectangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    num = a * b;
                    break;

                case "circle":
                    a = double.Parse(Console.ReadLine());
                    num = Math.PI * Math.Pow(a, 2);
                    break;

                default:
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    num = 0.5 * a * b;
                    break;
            }
            Console.WriteLine("{0:##.000}", num);

        }
    }
}
