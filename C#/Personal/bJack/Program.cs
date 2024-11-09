using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добре дошли в Казиното <<Лас Вегас>>!\n");
            Console.WriteLine("Дилър: Колко пари имаш, млади момко?");
            Console.Write("Играч: ");
            int total = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n*Правилата са прости!\nВ играта, която ще играеш, ще бъдат включени следните карти:\n2, 3, 4, 5, 6, 7, 8, 9, 10 и JOKER.\nКойто изтегли по-голяма карта, печели!*\n");
            while (total > 0)
            {
                Random i = new Random();
                int player = i.Next(2, 12), dealer = i.Next(2, 12);
                string playerC = "", dealerC = "";

                if (player == 11)
                {
                    playerC = "JOKER";
                }
                else
                {
                    playerC = Convert.ToString(player);
                }

                if (dealer == 11)
                {
                    dealerC = "JOKER";
                }
                else
                {
                    dealerC = Convert.ToString(dealer);
                }
                int enter;
                do
                {
                    Console.WriteLine("Дилър: Колко залагаш, млади момко?");
                    Console.Write("Играч: ");
                    enter = Int32.Parse(Console.ReadLine());
                }
                while (enter > total);
                Console.WriteLine("*Ти изтегли следната карта: " + player + "*");
                Console.WriteLine("Дилър: Искате ли да увеличите залога си? (y/n): ");
                Console.Write("Играч: ");
                string answer = Console.ReadLine();
                int add;
                switch (answer)
                {
                    case "y":
                        do
                        {
                            Console.WriteLine("Дилър: С колко?");
                            Console.Write("Играч: ");
                            add = Int32.Parse(Console.ReadLine());
                        }
                        while (add > enter);
                        enter += add;
                        break;

                    default:
                        Console.WriteLine("Дилър: ОК!");
                        break;
                }
                Console.WriteLine("Играч - " + playerC);
                Console.WriteLine("Дилър - " + dealerC);
                if (player > dealer)
                {
                    Console.WriteLine("*Поздравления! Вие спечелихте: " + enter * 2 + ".*");
                    total += enter * 2;
                }
                else if (dealer > player)
                {
                    Console.WriteLine("*За съжаление Вие изгубихте " + enter + "!*");
                    total -= enter;
                }
                else
                {
                    Console.WriteLine("*Само какъв късмет! Равенство!*");
                }
                Console.WriteLine("\nОстанали пари: " + total);
            }
            Console.WriteLine("Дилър: Надявам се, че си се забавлявал, малди момко! Довиждане!");
            Console.ReadKey();
        }
    }
}