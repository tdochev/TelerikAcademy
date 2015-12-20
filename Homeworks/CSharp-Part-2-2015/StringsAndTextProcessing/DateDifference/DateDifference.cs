//Problem 16. Date difference
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;

class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Enter the first date: ");
        DateTime firstDate = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Enter the second date: ");
        DateTime secondDate = Convert.ToDateTime(Console.ReadLine());
        TimeSpan distance = secondDate - firstDate;
        Console.WriteLine("Distance: {0} days", distance.Days); 
    }
}