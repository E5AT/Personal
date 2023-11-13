using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11
{
    public class Student
    {
        public string clas, id, name;
        public double dBEL, dForeign, dMath, dPsyc, dChem, dBio;
        public double average;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            Console.Write("Име: ");  std.name = Console.ReadLine();
            Console.Write("Клас: "); std.clas = Console.ReadLine();
            Console.Write("Номер: "); std.id = Console.ReadLine();

            Console.Write("БЕЛ: "); std.dBEL = double.Parse(Console.ReadLine());
            Console.Write("Чужд език: "); std.dForeign = double.Parse(Console.ReadLine());
            Console.Write("Математика: "); std.dMath = double.Parse(Console.ReadLine());
            Console.Write("Физика: "); std.dPsyc = double.Parse(Console.ReadLine());
            Console.Write("Химия: "); std.dChem = double.Parse(Console.ReadLine());
            Console.Write("Биология: "); std.dBio = double.Parse(Console.ReadLine());
            std.average = (std.dBEL + std.dForeign + std.dMath + std.dPsyc + std.dChem + std.dBio) / 6;

            Console.WriteLine(@"
С П Р А В К А
за успеха на {0}, ученик от
{1} клас, номер {2}
БЕЛ        - {3,4:0.00}
Чужд език  - {4,4:0.00}
Математика - {5,4:0.00}
Физика     - {6,4:0.00}
Химия      - {7,4:0.00}
Биология   - {8,4:0.00}
Среден успех - {9,4:0.00}", std.name, std.clas, std.id, std.dBEL, std.dForeign, std.dMath, std.dPsyc, std.dChem, std.dBio, std.average);
        }
    }
}
