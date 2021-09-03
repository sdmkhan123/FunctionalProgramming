using System;

namespace FunctionalProgramming
{
    class Program
    {
        static bool checkYear(int year)
        {
            // If a year is multiple of 400 OR multiple of 4 and not multiple of 100, then it is a leap year
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programming");
            Console.WriteLine("enter 4 digit year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write(checkYear(year) ? "Leap Year" : "Not a Leap Year");
        }
    }
}
