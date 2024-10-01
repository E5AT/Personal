using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] nums = new int[length];
            nums[0] = num;
            int copy = num;
            for (int i = 1; i < length; i++)
            {
                nums[i] = num += copy;
            }
            return nums; }

            static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            foreach (int n in ArrayOfMultiples(num, length)){
                Console.Write($"{n}, ");
            }
        }
    }
}
