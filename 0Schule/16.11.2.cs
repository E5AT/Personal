using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._11._2
{
    class Car
    {
        private string brand;
        private string model;

      
        public Car(string Brand,string Model)
        {
            brand = Brand;
            model = Model;
        }
        public void text()
        {
            Console.WriteLine(brand + " " + model);
        }

        static void Main(string[] args)
        {
            Car Car1 = new Car(Console.ReadLine(), Console.ReadLine());
            Car1.text();
        }
    }
}
