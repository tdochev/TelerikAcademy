//Problem 3. Decimal to hexadecimal
//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHex
{
    const int BaseSystem = 16;
    static void Main()
    {
        Console.WriteLine("Please enter a decimal number to convert it to hexadecimal:");
        int input = int.Parse(Console.ReadLine());
        string result = string.Empty;
        int remainder;
        while (input > 0)
        {
            remainder = input % BaseSystem;
            input /= BaseSystem;
            switch (remainder)
            {
                case 10:
                    result = "A" + result;
                    break;
                case 11:
                    result = "B" + result;
                    break;
                case 12:
                    result = "C" + result;
                    break;
                case 13:
                    result = "D" + result;
                    break;
                case 14:
                    result = "E" + result;
                    break;
                case 15:
                    result = "F" + result;
                    break;
                default:
                    result = remainder.ToString() + result;
                    break;
            }
        }
        Console.WriteLine("You hexadecimal result is: " + result);
    }

}