using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0prj
{
    class Math
    {
        public Math(double num1,double num2,char op)
        {
            switch (op)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;

                case '/':
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;

                default:
                    Console.WriteLine("There was an error!");
                    break;
            }
        }
    }
}
