using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void ReverseAndNot(int i)
        {
            string I = i.ToString();
            string[] array = new string[I.Length];
            string[] array2 = new string[I.Length];
            
            for (int x = 0; x < I.Length; x++)
            {
                array[x] = I[x].ToString();
            }
            Array.Copy(array, array2, array.Length);
            Array.Reverse(array);
            for(int x = 0; x < array.Length; x++)
                Console.Write(array[x]);

            for (int x = 0; x < array.Length; x++)
                Console.Write(array2[x]);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ReverseAndNot(n);
        }
    }
}