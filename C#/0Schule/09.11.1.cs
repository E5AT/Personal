using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._11._1
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
            //input
            Car myCar = new Car();
            Console.Write("Марка: "); myCar.brand = Console.ReadLine();
            Console.Write("Модел: "); myCar.model = Console.ReadLine();
            Console.Write("Обем на двигателя: "); myCar.engineVolume = int.Parse(Console.ReadLine());
            Console.Write("Година на производство: "); myCar.yearProd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //processes
            double annualTax = 0.2 * myCar.engineVolume;
            if (myCar.yearProd >= 2000) annualTax += 70.00;
            else if(myCar.yearProd<=2010) annualTax += 60.00;
            else annualTax += 50.00;

            ///output
            Console.WriteLine("Данъкът на {0}, {1},",myCar.brand,myCar.model);
            Console.WriteLine("с обем на двигателя {0},",myCar.engineVolume);
            Console.WriteLine("произведена през {0} година,",myCar.yearProd);
            Console.WriteLine("е {0,6:###.00} лева.",annualTax);
            Console.ReadLine();
        }
    }
}
