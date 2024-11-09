using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Human> lstHuman = new List<Human>();
        string firstName, lastname;
        int age;
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("First name: ");
            firstName = Console.ReadLine();
            Console.Write("Last name: ");
            lastname = Console.ReadLine();
            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Your choice[s - student] , [w - worker]: ");
        string choice = Console.ReadLine();
            if (choice == "s")
            {
                Console.Write("Grade: ");
                double mark = double.Parse(Console.ReadLine());
                lstHuman.Add(new Student(firstName, lastname,
                age, mark));
            }
            else if (choice == "w")
            {
                Console.Write("Wage: ");
                double wage = double.Parse(Console.ReadLine());
                Console.Write("Hours worked: ");
                double workHours = double.Parse(Console.ReadLine
                ());
                lstHuman.Add(new Worker(firstName, lastname,
                age, wage, workHours));
            }
        }
        for (int i = lstHuman.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(lstHuman[i]);
        }
    }
}
public class Human
{
    private string firstName;
    private string lastName;
    private int age;
    public Human(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    public override string ToString()
    {
        return this.firstName + " " + this.lastName + ", " + this.age + " years old";
    }
}
public class Student : Human
{
    private double mark;
    public Student(string firstName, string lastName, int
    age, double mark) : base(firstName, lastName, age)
    {
        this.mark =
mark;
    }
    public override string ToString()
    {
        return $"{base.ToString()}, grade: {this.mark:f2}";
    }
}
public class Worker : Human
{
    private double wage;
    private double workHours;
    public Worker(string firstName, string lastName, int
    age, double wage, double workHours) : base(firstName, lastName,
    age)
    {
        this.wage = wage;
        this.workHours = workHours;
    }
    public double WagePerHour()
    {
        return this.wage * this.workHours;
    }
    public override string ToString()
    {
        return $"{base.ToString()}, salary: ${WagePerHour():f2}";
    }
}