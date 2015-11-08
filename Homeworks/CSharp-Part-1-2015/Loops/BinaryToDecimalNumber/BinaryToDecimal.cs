//Problem 13. Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:
//binary 	                    decimal
//0 	                        0
//11 	                        3
//1010101010101011 	            43691
//1110000110000101100101000000 	236476736

using System;

namespace BinaryToDecimalNumber
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Please enter binary to convert it to decimal: ");
            string binary = Console.ReadLine();
            long number = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                number = number * 2 + (binary[i] - '0');
            }
            Console.WriteLine(number);
        }
    }
}
