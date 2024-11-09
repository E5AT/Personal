using System;
using System.Collections.Generic;
using System.Linq;
namespace DZI
{
    class Zad26
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            var input = Console.ReadLine().Split(' ').ToList();
            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "Add":
                        for (int i = 1; i < input.Count; i++)
                            words.Add(input[i]);
                        break;
                    case "Update":
                        for (int i = 0; i < words.Count; i++)
                        {
                            string firstLetter =
                            words[i].Substring(0, 1).ToUpper();
                            string restOfWord =
                            words[i].Substring(1);
                            words[i] = firstLetter + restOfWord;
                        }
                        break;
                    case "Remove":
                        int index = int.Parse(input[1]);
                        words.RemoveAt(index);
                        break;
                    case "Search":
                        string search = input[1];
                        if (words.IndexOf(search) != -1)
                            Console.WriteLine(words[words.IndexOf(search)]);
                        else Console.WriteLine("Not contained.");
                        break;
                    case "Length":
                        int length = int.Parse(input[1]);
                        var result = words.Where(x => x.Length ==
                        length).ToList();
                        if (result.Any())
                            Console.WriteLine(string.Join("-",
                            result));
                        else Console.WriteLine("Not contained.");
                        break;
                    case "Insert":
                        int position = int.Parse(input[1]);
                        string item = input[2];
                        try
                        {
                            words.Insert(position, item);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("There are not enough items in the list.", ex);
                        }
                        break;
                    case "Print":
                        Console.WriteLine(string.Join("; ", words));
                        break;
                }
                input = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}