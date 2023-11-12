using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());
            double shoe = tax - (tax * 0.4);

            //Console.WriteLine(shoe);
            double ekip = shoe - (shoe*0.2);

            //Console.WriteLine(ekip);
            double ball = 0.25 * ekip;

            //Console.WriteLine(ball);
            double accessories = 0.20 * ball;

            double sum = tax + shoe + ekip + ball + accessories;
            Console.WriteLine(sum);
        }
    }
}
