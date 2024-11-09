using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int naylon = int.Parse(Console.ReadLine());
            int boq = int.Parse(Console.ReadLine());
            int razdelitel = int.Parse(Console.ReadLine());
            int rabota = int.Parse(Console.ReadLine());
            double sumProduct = ((naylon + 2) * 1.50 + ((boq + (boq*0.10)) * 14.50) + (razdelitel * 5.00) + 0.40);
            double sumMaystor = (sumProduct * 0.30) * rabota;
            double sum = sumProduct + sumMaystor;
            Console.WriteLine(sum);
        }
    }
}
