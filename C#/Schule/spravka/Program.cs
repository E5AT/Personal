using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace spravka
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" SPRAVKA NA UCHENIKA ");
            Console.WriteLine("");
            Console.Write("Ime na uchenika ");
            string a1 = Console.ReadLine();
            Console.Write("Prezime na uchenika ");
            string a2 = Console.ReadLine();
            Console.Write("Familiq na uchenika ");
            string a3 = Console.ReadLine();
            Console.Write("Rojdena data ");
            string a4 = Console.ReadLine();
            Console.Write("Mqsto na rajdane ");
            string a5 = Console.ReadLine();
            Console.Write("Uchilishte na uchenika ");
            string a6 = Console.ReadLine();
            Console.Write("Klas na uchenika ");
            string a7 = Console.ReadLine();
            Console.Write("Nomer na uchenika ");
            string a8 = Console.ReadLine();
            Console.Write("Profil na uchenika ");
            string a9 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" SPRAVKA NA UCHENIKA ");
            Console.WriteLine("Ime na uchenika " + a1);
            Console.WriteLine("Prezime na uchenika " + a2);
            Console.WriteLine("Familiq na uchenika " + a3);
            Console.WriteLine("Rojdena data " + a4);
            Console.WriteLine("Mqsto na rajdane" + a5);
            Console.WriteLine("Uchilishte na uchenika" + a6);
            Console.WriteLine("Klas na uchenika" + a7);
            Console.WriteLine("Nomer na uchenika" + a8);
            Console.WriteLine("Profil na uchenika" + a9);
            Console.Read();


        }
    }
}