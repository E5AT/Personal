using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._11._0
{
    class Car
    {
        public string brand;
        public int price;

        public Car(string brand,int price)
        {
            this.brand = brand;
            this.price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car("Opel", 15000);
            Console.WriteLine($"My car's brand is {Car1.brand} and she costs {Car1.price} lv");
        }
    }
}
