//Problem 5. Workdays
//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Globalization;
using System.Linq;

class Workdays
{
    static DateTime[] PublicHolidays = 
    {
    new DateTime(2015, 1, 1),
    new DateTime(2015, 12, 24),
    new DateTime(2015, 12, 25),
    new DateTime(2015, 12, 31),
    new DateTime(2016, 1, 1),
    };
    static int CalculateWordays(DateTime date)
    {
        int workdays = 0;
        DateTime currentDate = DateTime.Now;
        while (currentDate < date)
        {
            bool isPublicHoliday = false;
            for (int i = 0; i < PublicHolidays.Length; i++)
            {
                if (PublicHolidays[i].Date == currentDate.Date )
                {
                    isPublicHoliday = true;
                    break;
                }
            }
            if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday && !isPublicHoliday)
            {
                workdays++;
            }
            currentDate = currentDate.AddDays(1);
        }
        return workdays;
    }
    static void Main()
    {
        Console.WriteLine("Please enter a date in the following format: {0}", CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("from today till {0} there are {1} woring days.", date.ToShortDateString() ,CalculateWordays(date));
    }
}
