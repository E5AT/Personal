using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11
{
    public class Student
    {
        public string clas, id, name;

        private double dBEL, dForeign, dMath, dPsyc, dChem, dBio;
        public double DBEL
        { set { this.dBEL = value; } get { return this.dBEL; } }
        public double DForeign
        { set { this.dForeign = value; } get { return this.dForeign; } }
        public double DMath
        { set { this.dMath = value; } get { return this.dMath; } }
        public double DPsyc
        { set { this.dPsyc = value; } get { return this.dPsyc; } }
        public double DChem
        { set { this.dChem = value; } get { return this.dChem; } }
        public double DBio
        { set { this.dBio = value; } get { return this.dBio; } }

        private double average;
        public double Average
        { set { this.average = value; } get { return this.average; } }


        public void calcAverage()
        {
            this.average = (this.dBEL + this.dForeign + this.DMath + this.dPsyc + this.dChem + this.dBio) / 6;
        }

        public void spravka(Student std)
        {
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
Среден успех - {9,4:0.00}", std.name, std.clas, std.id, std.DBEL, std.DForeign, std.DMath, std.DPsyc, std.DChem, std.DBio, std.Average);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            Console.Write("Име: "); std.name = Console.ReadLine();
            Console.Write("Клас: "); std.clas = Console.ReadLine();
            Console.Write("Номер: "); std.id = Console.ReadLine();

            Console.Write("БЕЛ: "); std.DBEL = double.Parse(Console.ReadLine());
            Console.Write("Чужд език: "); std.DForeign = double.Parse(Console.ReadLine());
            Console.Write("Математика: "); std.DMath = double.Parse(Console.ReadLine());
            Console.Write("Физика: "); std.DPsyc = double.Parse(Console.ReadLine());
            Console.Write("Химия: "); std.DChem = double.Parse(Console.ReadLine());
            Console.Write("Биология: "); std.DBio = double.Parse(Console.ReadLine());

            std.calcAverage();
            std.spravka(std);
        }
    }
}
