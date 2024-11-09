using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4prj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name: "); string firstName = Console.ReadLine();
            Console.Write("Last name: "); string lastName = Console.ReadLine();
            Console.Write("Town: "); string town = Console.ReadLine();
            Console.Write("E-mail: "); string eMail = Console.ReadLine();
            Console.Write("Blood group (0-/0+/A-/A+/B-/B+/AB-/AB+): "); string bloodGroup = Console.ReadLine();
            Console.WriteLine("Thanks for your blood donation! Here is your receipt :)!\n");

            Console.WriteLine("----------------------------");
            Console.WriteLine("American Blood Thieves Corp.");
            Console.WriteLine("              California,USA");
            Console.WriteLine(firstName+" "+lastName);
            Console.WriteLine(town);
            Console.WriteLine(eMail);
            Console.WriteLine();
            Console.WriteLine("Blood:");
            Console.WriteLine("From: "+bloodGroup);
            Console.Write("To: ");
            switch (bloodGroup)
            {
                case "0-":
                    Console.WriteLine("Everyone");
                    break;

                case "0+":
                    Console.WriteLine("AB+, A+, B+ and O+");
                    break;

                case "A-":
                    Console.WriteLine("AB-, AB+, A+ and A-");
                    break;

                case "A+":
                    Console.WriteLine("AB+ and A+");
                    break;

                case "B-":
                    Console.WriteLine("B-, B+, AB- and AB+");
                    break;

                case "B+":
                    Console.WriteLine("B+ and AB+");
                    break;

                case "AB-":
                    Console.WriteLine("AB- and AB+");
                    break;

                case "AB+":
                    Console.WriteLine("AB+");
                    break;

                default:
                    Console.WriteLine("Noone");
                    break;
            }
            Console.WriteLine("----------------------------");
        }
    }
}
