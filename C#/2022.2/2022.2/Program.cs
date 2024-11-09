using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022._2
{
    class Program
    {
        static string Poliandrome(string number)
        {
            {
                for (int i = 0, j = number.Length - 1; i <= j; i++, j--)
                {
                    if (number[i] != number[j]) return $"{number} is NOT a palindrome";
                }
                return $"{number} is a palindrome";
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Poliandrome(n.ToString()));
        }
    }
}
