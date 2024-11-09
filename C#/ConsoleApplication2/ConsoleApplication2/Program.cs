using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ArrayList nums = new ArrayList();
            List<int> count = new List<int>();
            for (int i =0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (nums.Contains(num)) count[nums.IndexOf(num)]++;
                else
                {
                    nums.Add(num);
                    count.Add(1);
                }
            }
            for(int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine($"число: {nums[i]}, брой: {count[i]}");
            }
        }
    }
}
