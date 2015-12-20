//Problem 19. Dates from text in Canada
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;

class DatesFromText
{
    static void Main()
    {
        Console.WriteLine("Please enter a text containing dates to extract the dates that match the format DD.MM.YYYY:");
        string[] inputAsArray = Console.ReadLine().Split(new[] {" ",")", ". "}, StringSplitOptions.RemoveEmptyEntries);
        DateTime result = new DateTime();
        CultureInfo provider = CultureInfo.InvariantCulture;
        string format = "d.M.yyyy";

        for (int i = 0; i < inputAsArray.Length; i++)
        {
            try
            {
                result = DateTime.ParseExact(inputAsArray[i], format, provider);
                Console.WriteLine(result.Date.ToString(),
                  CultureInfo.CreateSpecificCulture("en-CA"));
            }
            catch 
            { 
            }
        }

    }
}

