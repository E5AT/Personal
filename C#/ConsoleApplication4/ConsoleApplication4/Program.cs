using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        public static int CountVowels(string str)
        {
            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char[] s = str.ToCharArray();
            for (int i = 0; i < vowels.Length; i++)
                if (s.Contains(vowels[i]))
                {
                    s[str.IndexOf(vowels[i])] = 'w';
                    count++;
                }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CountVowels("anan"));
        }
    }
}
