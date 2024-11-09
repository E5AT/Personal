using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack
{
    public class blackJack
    {
        public void welcome()
        {
            Console.WriteLine(@"Welcome!
██████████████]99%");
            Console.ReadLine();
        }

        public int Convert(int a)
        {
            switch(a)
            {
                case 12: case 13: case 14:
                    return 10;

                default:
                    return a;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            blackJack bj = new blackJack();
            bj.welcome();
        }
    }
}
