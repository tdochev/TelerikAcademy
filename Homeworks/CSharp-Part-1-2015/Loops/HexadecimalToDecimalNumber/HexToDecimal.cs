//Problem 15. Hexadecimal to Decimal Number
//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:
//hexadecimal 	decimal
//FE 	254
//1AE3 	6883
//4ED528CBB4 	338583669684

using System;

class HexToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a hexadecimal to convert it to decimal: ");
        string hex = Console.ReadLine();
        long number = 0;
        for (int i = hex.Length-1, j=0; i >= 0; i--,j++)
        {
            switch (hex[i])
            {
                case 'A':
                    number += 10 * (long)Math.Pow(16, j);
                    break;
                case 'B':
                    number += 11 * (long)Math.Pow(16, j);
                    break;
                case 'C':
                    number += 12 * (long)Math.Pow(16, j);
                    break;
                case 'D':
                    number += 13 * (long)Math.Pow(16, j);
                    break;
                case 'E':
                    number += 14 * (long)Math.Pow(16, j);
                    break;
                case 'F':
                    number += 15 * (long)Math.Pow(16, j);
                    break;
                default:
                    number += (hex[i] - '0') * (long)Math.Pow(16, j);
                    break;
            }
        }
        Console.WriteLine(number);
    }
}

