//Problem 2. Binary to decimal
//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    const int BaseSystem = 2;
    static void Main()
    {
        Console.WriteLine("Please enter a binary to convert it to decimal:");
        string input = Console.ReadLine();
        int result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            result += (input[i] - '0') * (int)Math.Pow(BaseSystem, input.Length - i - 1);
        }
        Console.WriteLine("Your decimal result is: " + result);
    }
}