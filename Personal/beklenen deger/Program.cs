using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beklenen_deger
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Merhaba! Evrim Agacinin su linkteki videosunu izlerken bir proje fikri geldi aklima:
             https://youtu.be/03vtYgfzqL0?si=9fUkpxts9ar8wEiS&t=523
             Gercekten ilginc bir fikir!
             Neyse, hemen deneyelim :).
             
             17:30
             21.10.2023 */

            int para = 0;
            for (int kere = 0; kere <= 1000; kere++)
            {
                Random i = new Random();
                int madeni = 0;
                madeni = i.Next(1, 3);
                switch (madeni)
                {
                    case 1:
                        Console.WriteLine("Yazi +20");
                        para += 20;
                        break;

                    default:
                        Console.WriteLine("Tura -10");
                        para -= 10;
                        break;
                }
            }
            Console.WriteLine($"Toplam para: {para}");
            Console.WriteLine("(5000 olmasi lazim!)");
            Console.Read();

        }
    }
}