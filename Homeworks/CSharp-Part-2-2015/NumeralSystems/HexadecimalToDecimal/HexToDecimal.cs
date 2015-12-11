//Problem 4. Hexadecimal to decimal
//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexToDecimal
{
    const int BaseSystem = 16;
    static void Main()
    {
        Console.WriteLine("Please enter a binary to convert it to decimal:");
        string input = Console.ReadLine();
        int result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int exponent = (int)Math.Pow(BaseSystem, input.Length - i - 1);
            switch (char.ToUpper(input[i]))
            {
                case 'A':
                    result += 10 * exponent;
                    break;
                case 'B':
                    result += 11 * exponent;
                    break;
                case 'C':
                    result += 12 * exponent;
                    break;
                case 'D':
                    result += 13 * exponent;
                    break;
                case 'E':
                    result += 14 * exponent;
                    break;
                case 'F':
                    result += 15 * exponent;
                    break;
                default:
                    result += (input[i] - '0') * exponent;
                    break;
            }
           
        }
        Console.WriteLine("Your decimal result is: " + result);
    }
}
