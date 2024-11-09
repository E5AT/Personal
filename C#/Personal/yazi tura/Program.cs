using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazi_tura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Yazi Tura'ya Hos Geldin!");
            Console.WriteLine("------------------------");

            double toplam, bahis = 0;
            Random random = new Random();
            string tahmin = "", mPara = "";

            Console.Write("Toplam para: ");
            toplam = Convert.ToDouble(Console.ReadLine());

            while (toplam > 0)
            {
                tahmin = "";
                bahis = 1.7976931348623157E+308;
                while (toplam < bahis)
                {
                    Console.Write("Bahis: ");
                    bahis = Convert.ToDouble(Console.ReadLine());
                }
                while (tahmin != "y" && tahmin != "t")
                {
                    Console.Write("(y/t) Oyuncu: ");
                    tahmin = Convert.ToString(Console.ReadLine());
                }

                switch (random.Next(1, 3))
                {
                    case 1:
                        mPara = "y";
                        break;

                    case 2:
                        mPara = "t";
                        break;
                }
                Console.WriteLine("Madeni para: " + mPara);

                if (tahmin == mPara)
                {
                    bahis *= 2;
                    toplam += bahis;
                }
                else
                {
                    toplam -= bahis;
                }
                Console.WriteLine();
                Console.WriteLine("Toplam para: " + toplam);
            }
            Console.ReadKey();
        }
    }
}