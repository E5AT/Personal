using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLot
{
    public class Cars
    {

        public string[] brandModel = new string[99];
        
        public void parkingLot(int carNum)
        {
            Console.WriteLine("parkingLot:");
            for (int i = 0, i2 = 1; i < carNum; i++, i2++)
            {
                Console.Write(brandModel[i]);

                for (int i1 = 1; i1 <= (20 - (brandModel[i]).Count()); i1++)
                {
                    Console.Write(" ");
                }
                if (i2 % 3 == 0) Console.Write("\n");
            }
            Console.Beep();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();
            Console.Write("Welcome to the parkingLot!\nPlease enter the number of your cars (there are 99 of 'em): "); int carNum = int.Parse(Console.ReadLine());
            Console.WriteLine("OK! Now enter the cars as follows: Brand Model");

            
            for (int i=1,i1=0; i <= carNum; i++,i1++)
            {
                Console.Write(i+". "); cars.brandModel[i1] = Console.ReadLine();
            }

            Console.WriteLine();
            cars.parkingLot(carNum);
            Console.ReadLine();
        }
    }
}
