//Problem 1. Decimal to binary
//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    const int BaseSystem = 2;
    static void Main()
    {
        Console.WriteLine("Please enter a decimal to convert it to binary:");
        int input = int.Parse(Console.ReadLine());
        string result = string.Empty;
        int remainder;
        while (input > 0)
        {
            remainder = input % BaseSystem;
            input /= BaseSystem;
            result = remainder.ToString() + result;
        }
        Console.WriteLine("You binary result is: " + result);
    }
}

