using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpt0
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "", lastName = "";
            int balance = 0;
            bool exit = false;
            Console.WriteLine("------------------");
            Console.WriteLine("Welcome to US Bank!");
            Console.WriteLine("------------------\n");

            Console.Write("It looks like you don't have an account, would you like to create one? (y/n): ");
            string an1 = Console.ReadLine();

            if (an1 == "n")
            {
                Console.WriteLine("Yes, you want!");
            }

            Console.WriteLine();
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Random i = new Random();
            string a = Convert.ToString(i.Next(0, 10));
            string b = Convert.ToString(i.Next(0, 10));
            string c = Convert.ToString(i.Next(0, 10));
            string d = Convert.ToString(i.Next(0, 10));
            string e = Convert.ToString(i.Next(0, 10));
            string f = Convert.ToString(i.Next(0, 10));
            string aN = a + b + c + d + e + f;
            Console.WriteLine($"Your account number is: {aN}");
            Console.WriteLine("Thanks for creating an account!");

            while (exit == false)
            {
                Console.ReadLine();
                Console.WriteLine("Please select one of the following options: ");
                Console.WriteLine("1. View Account Details.");
                Console.WriteLine("2. Deposit.");
                Console.WriteLine("3. Withdraw.");
                Console.WriteLine("4. Exit.");
                Console.Write("(1/2/3/4): ");
                int an2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (an2)
                {
                    case 1:
                        string fullName = firstName + " " + lastName;
                        string userName = ((fullName.ToLower()).Replace(" ", "_")).Insert(0, "@");
                        Console.WriteLine($"User name: {userName}");
                        Console.WriteLine($"Full name: {fullName}");
                        Console.WriteLine($"Account balance: {balance}");
                        break;

                    case 2:
                        Console.WriteLine($"Account balance: {balance}");
                        Console.Write("Please enter the amount of money you would like to deposit to your account: ");
                        int add = 0;
                        add = Int32.Parse(Console.ReadLine());
                        Console.WriteLine($"Congratulations you have deposited {add} money into your bank account!");
                        balance += add;
                        Console.WriteLine($"Account balance: {balance}");
                        break;

                    case 3:
                        Console.WriteLine($"Account balance: {balance}");
                        Console.Write("Please enter the amount of money you would like to withdraw from your account: ");
                        int min = 0;
                        min = Int32.Parse(Console.ReadLine());
                        Console.WriteLine($"Congratulations you have withdrawn {min} money from your bank account!");
                        balance -= min;
                        Console.WriteLine($"Account balance: {balance}");
                        break;

                    case 4:
                        exit = true;
                        break;
                }
            }
            Console.WriteLine("Thank you for visiting US Bank!");
            Console.Read();

        }
    }
}