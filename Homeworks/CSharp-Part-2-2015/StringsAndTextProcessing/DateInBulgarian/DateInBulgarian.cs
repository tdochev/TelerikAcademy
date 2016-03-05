//Problem 17. Date in Bulgarian
//Write a program that reads a date and time given in the format: 
//day.month.year hour:minute:second and prints the date and time
//after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;

class DateInBulgarian
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please eneter a date in the following formaty day.month.year hour:minute:second");
        string dateString = Console.ReadLine();
        DateTime result;
        CultureInfo provider = CultureInfo.InvariantCulture;
        string format = "dd.MM.yyyy hh:mm:ss";
        try
        {
            result = DateTime.ParseExact(dateString, format, provider);
            Console.WriteLine(result.ToString());
            result = result.AddHours(6.5d);
            Console.WriteLine(result.ToString() + " Day of the week: " + result.DayOfWeek.ToString());
        }
        catch (FormatException)
        {
            Console.WriteLine("{0} is not in the correct format.", dateString);
        }

    }
}