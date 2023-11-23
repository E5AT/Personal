using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Hotel
    {
        public void textGram()
        {
            Console.WriteLine(@" ___________________________
|                           |
|       Skibidi Hotel       |
|___________________________|
|       |           |       |
|  060  |           |  061  |
|_______|___________|_______|
|       |           |       |
|  050  |           |  051  |
|_______|___________|_______|
|       |           |       |
|  040  |           |  041  |
|_______|___________|_______|
|       |           |       |
|  030  |           |  031  |
|_______|___________|_______|
|       |           |       |
|  020  |           |  021  |
|_______|___________|_______|
|       |           |       |
|  010  |           |  011  |
|_______|___________|_______|");
        }

        public void receipt(string a,int b,string c)
        {
            Console.WriteLine(@"Hotel Receipt:
------------------------------------
Room {0}
is reservated by {1} people/person.
This receipt is to {2},
and the date is 06.04.1920.
------------------------------------",a,b,c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            Console.WriteLine("Welcome to Online Hotel Room Booking System\n");
            Console.WriteLine("Here is picture of our hotel:");
            hotel.textGram();
            Console.Write("What's 'ur name?: "); string name = Console.ReadLine();
            Console.Write("Enter the number of wanted room: 0"); string num = Console.ReadLine();
            Console.Write("How many people are you?: "); int people = int.Parse(Console.ReadLine());
            Console.WriteLine();
            hotel.receipt(num, people, name);
        }
    }
}
