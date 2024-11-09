using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Number_100._._._200
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (100 > num) Console.WriteLine("Less than 100");
            else if (200 >= num) Console.WriteLine("Between 100 and 200");
            else Console.WriteLine("Greater than 200");
        }
    }
}
