using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._11
{
    class Program
    {
        public class Car
        {
            //атрибути
            public string brand;
            public string model;
            public int engineVolume;
            public int yearProd;
        }

        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.brand = "FlyingCar";
            myCar.model = "Mark1";
            myCar.engineVolume = 3000;
            myCar.yearProd = 2010;
            Console.Write(myCar.brand+", "+myCar.model+ ", ");
            Console.WriteLine(myCar.engineVolume+ ", "+myCar.yearProd);
            Console.ReadLine();
        }
    }
}
