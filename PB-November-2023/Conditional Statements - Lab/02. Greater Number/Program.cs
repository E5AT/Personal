using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1= int.Parse(Console.ReadLine());
            int num2= int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(num1,num2));
        }
    }
}
