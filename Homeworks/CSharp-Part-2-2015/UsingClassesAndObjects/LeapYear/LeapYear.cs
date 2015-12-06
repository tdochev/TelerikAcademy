//Problem 1. Leap year
//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;
using System.Globalization;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Please enter a year to check if it is leap");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} is {1}",year, DateTime.IsLeapYear(year) ? "a leap year" : "not a leap year");
        ;
    }
}
