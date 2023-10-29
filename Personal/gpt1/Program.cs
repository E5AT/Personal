using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpt1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to 'The Cinema'!");
                bool admin = false;
                string[] movies = { "American Psycho", "Fight Club", "Interstellar", "Léon: The Professional", "American History X" };
                Console.Write("Username: @"); string uName = Console.ReadLine();
                if (uName == "admin")
                {
                    Console.Write("Password: "); int password = int.Parse(Console.ReadLine());
                    if (password == 12345)
                    {
                        admin = true;
                    }
                }
                Console.WriteLine();
                if (admin)
                {
                    Console.WriteLine("Its seems that ur an Admin!\nIn place of which movie you want to add new one?");
                    for (int i = 1, index = 0; i <= 5; i++)
                    {
                        Console.WriteLine($"{i}. {movies[index]}");
                        index++;
                    }
                    char answer = 'y';
                    while (answer != 'n')
                    {
                        int adminTool = 0; while (adminTool != 1 && adminTool != 2 && adminTool != 3 && adminTool != 4 && adminTool != 5)
                        { Console.Write("(1/2/3/4/5): "); adminTool = int.Parse(Console.ReadLine()); }
                        Console.Write("New movie name: "); string newMovie = Console.ReadLine();

                        switch (adminTool)
                        {
                            case 1:
                                movies[0] = newMovie;
                                break;

                            case 2:
                                movies[1] = newMovie;
                                break;

                            case 3:
                                movies[2] = newMovie;
                                break;

                            case 4:
                                movies[3] = newMovie;
                                break;

                            case 5:
                                movies[4] = newMovie;
                                break;
                        }
                        Console.WriteLine("\nCurrent list:");

                        for (int i = 1, index = 0; i <= 5; i++)
                        {
                            Console.WriteLine($"{i}. {movies[index]}");
                            index++;
                        }

                        Console.Write("Do you want to make any changes?\n(y/n): ");
                        answer = char.Parse(Console.ReadLine());
                    }

                }
                else
                {
                    Console.Write("Ur not an Admin!\nAnd that means you come here to watch movie :>!\nWhats ur name?: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Nobody visits this place, I will play whatever movie you want?\nJust pick one of em: ");

                    for (int i = 1, index = 0; i <= 5; i++)
                    {
                        Console.WriteLine($"{i}. {movies[index]}");
                        index++;
                    }
                    int answer = 0;
                    while (answer != 1 && answer != 2 && answer != 3 && answer != 4 && answer != 5)
                    {
                        Console.Write("(1/2/3/4/5): "); answer = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Good choice!");
                    string tickName = "";
                    switch (answer)
                    {
                        case 1:
                            tickName = movies[0];
                            break;

                        case 2:
                            tickName = movies[1];
                            break;

                        case 3:
                            tickName = movies[2];
                            break;

                        case 4:
                            tickName = movies[3];
                            break;

                        case 5:
                            tickName = movies[4];
                            break;
                    }
                    Console.WriteLine("Here is ur ticket:");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($" Name: {name}");
                    Console.WriteLine($" Movie: {tickName}");
                    Console.WriteLine(" Time: Today :>");
                    Console.WriteLine("------------------------------");
                    Console.ReadLine();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("There was an error during your process!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting 'The Cinema'!");
                Console.ReadLine();
            }
        }
    }
}
