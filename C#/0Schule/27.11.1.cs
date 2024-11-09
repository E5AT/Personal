using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._11._1
{
    class Car
    {
        static Car()
        {
            Console.WriteLine("Static Constructor");
        }

        public Car()
        {
            Console.WriteLine("Default Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Console.ReadLine();
        }
    }
}
