using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1prj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which day is it?\nIs this your question?\nUnfortunetly I dont know too!\nWhat's you first class?\nYour answer: ");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            Console.WriteLine();
            Classes(answer);
            Console.ReadLine();
        }

        static void Classes(string answer)
        {
            if(answer.Contains("chas")) { Console.WriteLine("Wait...\nI know! It's Monday :>!"); }
            else if(answer.Contains("bel")) { Console.WriteLine("Wait...\nI know! It's Tuesday :>!"); }
            else if (answer.Contains("geo")) { Console.WriteLine("Wait...\nI know! It's Wednesday :>!"); }
            else if (answer.Contains("angl")) { Console.WriteLine("Wait...\nI know! It's Thursday :>!"); }
            else if (answer.Contains("info")) { Console.WriteLine("Wait...\nI know! It's Friday :>!"); }
            else { Console.WriteLine("Sorry but... there was an error!\n(And maybe you'r in Backrooms :|)"); }
        }
    }
}
