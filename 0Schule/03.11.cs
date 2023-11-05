using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Car("Opel","Astra",1999,199);
			Car("Mazda","K360",2005,250);
			Car("BMW","i5",2015,300);
		}
		
		static void Car(string brand,string model,int year,int maxSpeed) 
		{
		  Console.WriteLine($"Our car is {year} {brand} {model} and it can go {maxSpeed} km/ph.");
		}
	}
}
