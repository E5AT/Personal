using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            int answer;
            double a, b, c, x, D, d, x1, x2;
            while (again)
            {
                Console.WriteLine("ax^2 + bx + c = 0");
                Console.Write("a = "); a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = "); b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c = "); c = Convert.ToDouble(Console.ReadLine());
                D = b * b - 4 * a * c;

                if (a == 0)
                {
                    x = -c / b;
                    Console.WriteLine("Решението на уравнението е: " + x);
                }
                else if (D < 0)
                {
                    Console.WriteLine("Няма решение");
                }
                else if (D == 0)
                {
                    x = -b / (2 * a);
                    Console.WriteLine("Едно решение: " + x);
                }
                else
                {
                    d = Math.Sqrt(D);
                    x1 = (-b + d) / (2 * a);
                    x2 = (-b - d) / (2 * a);

                    Console.WriteLine("Две решения: " + x1);
                    Console.WriteLine("             " + x2);
                }
                Console.Write("1/0: ");
                answer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (answer)
                {
                    case 1:
                        again = true;
                        break;

                    default:
                        again = false;
                        break;
                }
            }
            Console.WriteLine("Благодаря, че използвахте програмата ми!");
            Console.ReadKey();
        }
    }
}
