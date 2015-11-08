//Problem 16. Decimal to Hexadecimal Number
//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:
//decimal 	hexadecimal
//254 	FE
//6883 	1AE3
//338583669684 	4ED528CBB4

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Please eneter a number to convert it to binary: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        string binary = "";
        do
        {
            switch (decimalNumber % 16)
            {   
                case 10:
                    binary += "A";
                    break;
                case 11:
                    binary += "B";
                    break;
                case 12:
                    binary += "C";
                    break;
                case 13:
                    binary += "D";
                    break;
                case 14:
                    binary += "E";
                    break;
                case 15:
                    binary += "F";
                    break;
                case 16:
                    binary += "G";
                    break;
                default: binary += decimalNumber % 16;
                    break;
            }
            decimalNumber /= 16;
        } while (decimalNumber != 0);
        char[] binaryReversed = binary.ToCharArray();
        Array.Reverse(binaryReversed);
        Console.WriteLine(binaryReversed);
    }
}

