using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(guc(1));
            Console.WriteLine(guc(2));
            Console.WriteLine(guc(3));
            Console.WriteLine(guc(4));
            Console.WriteLine(guc(5));
            Console.WriteLine(guc(6));
            Console.WriteLine(guc(7));
            Console.WriteLine(guc(8));
            Console.WriteLine(guc(9));
            Console.WriteLine(guc(10));

            Console.ReadKey();
        }
        static string guc(int sayi)
        {
            return $"{sayi}^{sayi} = {sayi * sayi}";
        }
    }
}