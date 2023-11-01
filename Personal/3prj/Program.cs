using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3prj
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[] productPrices = { 3.00, 2.50, 2.00, 1.00, 0.60, 5.00, 3.00, 3.50, 3.00 };
                string[] productNames = { "Milk", "Bread", "Egg", "Potatoe", "Banana", "Bacon", "Butter", "Juice", "Biscuit" };
                bool viewCart = false, finish = false;
                double cart = 0.00;
                int[] count = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                while (finish != true)
                {
                    while (viewCart != true)
                    {
                        Console.WriteLine($"\t\t\tCart: ${cart.ToString("F2")}");
                        Products();
                        Console.WriteLine("#00 View cart");
                        Console.Write("#0"); int answr = int.Parse(Console.ReadLine());
                        switch (answr)
                        {
                            case 1:
                                cart += productPrices[0];
                                count[0] += 1;
                                break;

                            case 2:
                                cart += productPrices[1];
                                count[1] += 1;
                                break;

                            case 3:
                                cart += productPrices[2];
                                count[2] += 1;
                                break;

                            case 4:
                                cart += productPrices[3];
                                count[3] += 1;
                                break;

                            case 5:
                                cart += productPrices[4];
                                count[4] += 1;
                                break;

                            case 6:
                                cart += productPrices[5];
                                count[5] += 1;
                                break;

                            case 7:
                                cart += productPrices[6];
                                count[6] += 1;
                                break;

                            case 8:
                                cart += productPrices[7];
                                count[7] += 1;
                                break;

                            case 9:
                                cart += productPrices[8];
                                count[8] += 1;
                                break;

                            case 0:
                                viewCart = true;
                                break;

                            default:
                                break;
                        }
                        Console.WriteLine("------------------------------------");
                    }
                    Console.WriteLine("Your total is: $" + cart.ToString("F2"));
                    Console.WriteLine("Are you sure you will finish?");
                    Console.Write("(y/n): "); string answr2 = Console.ReadLine();
                    if (answr2 == "y") { finish = true; }
                    else { viewCart = false; }
                }
            }
            catch(Exception)
            {
                Console.WriteLine("There is an error, please come again soon :(!");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Thanks for visiting our Shop! See you soon :)!");
                Console.ReadLine();
            }
        }
        static void Products()
        {
            int[] productNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            string[] productNames = { "Milk", "Bread", "Egg", "Potatoe", "Banana", "Bacon", "Butter", "Juice", "Biscuit" };
            double[] productPrices = { 3.00, 2.50, 2.00, 1.00, 0.60, 5.00, 3.00, 3.50, 3.00 };

            for (int i = 0; i < productNames.Length; i++)
            {
                Console.Write($"#0{productNums[i]} ");
                Console.Write($"{productNames[i]}");
                string formattedPrice = productPrices[i].ToString("F2");
                int i1 = productNames[i].Length;
                while (i1<=10)
                {Console.Write(" ");
                    i1++;
                }
                Console.WriteLine($"${formattedPrice}");
            }
        }
    }
}
