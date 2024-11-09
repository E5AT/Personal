using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int S;
            string answer = "";
            Console.Write("Въведи число: ");
            S = int.Parse(Console.ReadLine());

            if (S == 0)
            {
                answer = "Числото е нула!";
            }
            if (S > 0)
            {
                answer = "Числото е положително!";
            }

            if (S < 0)
            { answer = "Числото е отрицателно!"; }

            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
