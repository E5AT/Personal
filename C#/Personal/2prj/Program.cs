using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2prj
{
    class Program
    {
        static void Main(string[] args)
        {
            Random i = new Random();
            int num = i.Next(1, 101);
            int guesses = 6;
            int guess = 0;
            while(guess!=num)
            {
                switch(guesses)
                {
                    case 6:
                        six();
                        break;

                    case 5:
                        five();
                        break;

                    case 4:
                        four();
                        break;

                    case 3:
                        three();
                        break;

                    case 2:
                        two();
                        break;

                    case 1:
                        one();
                        break;

                    case 0:
                        zero();
                        break;

                    case -1:
                        extra();
                        break;
                }
                if (guesses < 0) { break; }
                Console.Write("guess: ");  guess = int.Parse(Console.ReadLine());
                if (num != guess) { Console.WriteLine((num>guess)?"num>guess":"num<guess"); }
                Console.WriteLine();
                guesses--;
            }
            if (guesses < 0) { Console.WriteLine($"secret num: {num}\nYou lost! Thats bad :(!"); }
            else { Console.WriteLine($"secret num: {num}\n!!!Wow you've guessed the secret num! That's exciting man :D!!!"); }
            Console.ReadLine();
        }
        static void six()
        {
            Console.WriteLine("You have six guesses. Use them carefully!");
            Console.WriteLine("____");
            Console.WriteLine("|/   |");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|_____");
        }
        static void five()
        {
            Console.WriteLine("Five guesses left man...");
            Console.WriteLine(@" ____
|/   |
|   (_)
|    
|    
|    
|
|_____");
        }
        static void four()
        {
            Console.WriteLine("Four guesses... Maybe you are'nt in the right way bro :|");
            Console.WriteLine(@" ____
|/   |
|   (_)
|    |
|    |    
|    
|
|_____");
        }
        static void three()
        {
            Console.WriteLine("Wow three guesses! I can feel the stress!");
            Console.WriteLine(@" ____
|/   |
|   (_)
|   \|
|    |
|    
|
|_____");
        }
        static void two()
        {
            Console.WriteLine("I guess you are going to void >:(. Two guesses left!");
            Console.WriteLine(@" ____
|/   |
|   (_)
|   \|/
|    |
|    
|
|_____");
        }
        static void one()
        {
            Console.WriteLine("Maybe you'll be okay in The Void :(... I don't know! One guess...");
            Console.WriteLine(@" ____
|/   |
|   (_)
|   \|/
|    |
|   / 
|
|_____");
        }
        static void zero()
        {
            Console.WriteLine("Technically ur dead. But I guess I am a good person so... you have one extra guess :)!!!");
            Console.WriteLine(@" ____
|/   |
|   (_)
|   \|/
|    |
|   / \
|
|_____");
        }
        static void extra()
        {
            Console.WriteLine(" ____");
            Console.WriteLine("|/   |");
            Console.WriteLine("|   (_)");
            Console.WriteLine("|   /|\\");
            Console.WriteLine("|    |");
            Console.WriteLine("|   | |");
            Console.WriteLine("|");
            Console.WriteLine("|_____");
        }
    }
}
