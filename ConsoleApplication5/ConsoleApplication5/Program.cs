using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Car
    {
        private string brand;
        private int hPower;
        public Car(string a, int b)
        {
            brand = a;
            hPower = b;
        }
        public override string ToString()
        {
            return $"{brand}, {hPower}";
        }
    }

    class Pilot
    {
        private string name;
        private int age;
        private Car carp;
        private string category;
        public Pilot(string Name, int Age, Car car, string Category)
        {
            name = Name;
            age = Age;
            carp = car;
            category = Category;
        }
        public override string ToString()
        {
            return $"{name},{age},{category},{carp.ToString()}";
        }
    }

    class Rally
    {
        private string name;
        private int year;
        private List<Pilot> pilots;
        public Rally(string Name, int Year)
        {
            name = Name;
            year = Year;
            pilots = new List<Pilot>();
        }
        public void Add(Pilot p)
        {
            pilots.Add(p);
        }
        public void Info()
        {
            Console.WriteLine($"{name} - {year}");
            for(int i = 0; i < pilots.Count; i++)
            {
                Console.WriteLine(pilots[0].ToString());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string rName = Console.ReadLine();
            int rYear = int.Parse(Console.ReadLine());
            Rally rally = new Rally(rName, rYear);

            char answer;

            do
            {
                Console.WriteLine($"\n[a]dd [v]iew [q]uit");
                answer = char.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 'a':
                        Pilot pilot; Car car;
                        Console.Write("Pilot name: "); string pName = Console.ReadLine();
                        Console.Write("Age: "); int pAge = int.Parse(Console.ReadLine());
                        Console.Write("Category (A|B|C): "); string pCategory = Console.ReadLine();
                        Console.Write("Car model: "); string pModel = Console.ReadLine();
                        Console.Write("Car power (hp): "); int pPower = int.Parse(Console.ReadLine());
                        car = new Car(pModel, pPower);
                        pilot = new Pilot(pName, pAge, car, pCategory);
                        rally.Add(pilot);
                        break;

                    case 'v':
                        rally.Info();
                        break;
                        
                    default:
                        break;
                }
            } while (answer != 'q');
        }
    }
}
