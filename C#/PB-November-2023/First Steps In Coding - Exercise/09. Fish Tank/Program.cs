using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double precent = double.Parse(Console.ReadLine());
            double obem = (length * width * height)*0.001;
            Console.WriteLine(obem*(1-(precent*0.01)));
        }
    }
}
