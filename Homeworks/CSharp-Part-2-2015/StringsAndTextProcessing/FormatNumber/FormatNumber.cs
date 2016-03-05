//Problem 11. Format number
//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;

class FormatNumber
{
    const string formater = "{0,15:G}{0,15:X}{1,15:P}{0,15:E}";
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("{0,15}{1,15}{2,15}{3,15}", "Decimal", "Hex", "Percentage", "Scientific");
        Console.WriteLine(formater,number, (double)number / 100);
    }
}
