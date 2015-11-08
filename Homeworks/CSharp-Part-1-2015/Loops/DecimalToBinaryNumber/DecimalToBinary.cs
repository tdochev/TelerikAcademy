﻿//Problem 14. Decimal to Binary Number
//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:
//decimal 	binary
//0 	0
//3 	11
//43691 	1010101010101011
//236476736 	1110000110000101100101000000

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please eneter a number to convert it to binary: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        string binary = "";
        do
        {
            binary += decimalNumber % 2;
            decimalNumber /= 2;
        } while (decimalNumber != 0);
        char[] binaryReversed = binary.ToCharArray();
        Array.Reverse(binaryReversed);
        Console.WriteLine(binaryReversed);

    }
}
