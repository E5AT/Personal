using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1._10._24
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("E:\\C#\\Schule24\\1.10.24\\students.txt");
            int num2=0, num3=0, num4=0, num5=0, num6=0;
            string line = r.ReadLine();

            while (line != null)
            {
                if (line.Contains("2")) num2++;
                if (line.Contains("3")) num3++;
                if (line.Contains("4")) num4++;
                if (line.Contains("5")) num5++;
                if (line.Contains("6")) num6++;
                line = r.ReadLine();
            }

            Console.WriteLine("Слаб "+num2);
            Console.WriteLine("Среден "+num3);
            Console.WriteLine("Добър "+num4);
            Console.WriteLine("Много добър "+num5);
            Console.WriteLine("Отличен "+num6);
        }
    }
}
