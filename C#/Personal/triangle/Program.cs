using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПРОГРАМА ЗА НАМИРАНЕ НА ЛИЦЕ НА ТРИЪГЪЛНИК");
            Console.WriteLine("");
            Console.WriteLine("        *        ");
            Console.WriteLine("       ***       ");
            Console.WriteLine("      *****      ");
            Console.WriteLine("     *******     ");
            Console.WriteLine("    *********    ");
            Console.WriteLine("   ***********   ");
            Console.WriteLine("  *************  ");
            Console.WriteLine(" *************** ");
            Console.WriteLine("*****************");
            Console.WriteLine("");
            Console.Write("Основа = ");
            int o = int.Parse(Console.ReadLine());
            Console.Write("Височина = ");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            double S = 0.5 * o * w;
            Console.Write("Лице = " + S);
            Console.Read();
        }
    }
}