using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roulette
{
    public class Roulette
    {
        Random r = new Random();
        public int wNum, pNum;
        public char wColor, pColor;
        public string answer;

        //processes
        public char calcColor(int num)
        {
            if (num == 0) return 'g';
            else if (num % 2 == 0) return 'b';
            else return 'r';
        }
        public bool checkColor()
        {
            if (wColor == pColor) return true;
            else return false;
        }
        public bool checkEvenOrOdd()
        {
            if (wNum == 0) return false;
            else if (wNum % 2 == 0 && answer=="even") return true;
            else if (wNum % 2 != 0 && answer=="odd") return true;
            else return false;
        }
        public bool checkNum()
        {
            if (wNum == pNum) return true;
            else return false;
        }
        public void check(string a1,string a2)
        {
            bool win;

            if (a1 == "nums")
            {
                pNum = int.Parse(a2);
                win = checkNum();
            }
            else if (a1 == "eo")
            {
                answer = a2;
                win = checkEvenOrOdd();
            }
            else
            {
                pColor = char.Parse(a2);
                wColor = calcColor(wNum);
                win = checkColor();
            }

            if (win == true) rWin();
            else rLose();
        }

        //texts
        public void table()
        {
            Console.WriteLine(@"
1/2/3/4/5/  |
6/7/8/9/10/ |
11/12/13/   |
14/15/16/   |
17/18/19/   |
20/21/22/   |nums
23/24/25/   |
26/27/28/   |
29/30/31/   |
32/33/34/   |
35/36/      |
even/odd/   |eo
g/b/r       |gbr");
        }
        public void animation()
        {
            wNum = r.Next(0, 37);
            for(int i = 0; i < 36; i++)
            {
                Console.WriteLine(@"|-----
| {0}",r.Next(0,37));
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine(@"|-----
| {0}",wNum);
        }

        //results
        public void rWin()
        {
            Console.WriteLine("Congratulations, you win!");
        }
        public void rLose()
        {
            Console.WriteLine("Unfortunetly, you losed!");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Roulette r = new Roulette();
            r.table();
            Console.WriteLine();
            Console.Write("Answer1: "); string answer1 = Console.ReadLine();
            Console.Write("Answer2: "); string answer2 = Console.ReadLine();
            Console.WriteLine();
            r.animation();
            r.check(answer1, answer2);
        }
    }
}
