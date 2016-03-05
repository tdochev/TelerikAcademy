//Problem 10. Unicode characters
//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:
//input 	output
//Hi! 	\u0048\u0069\u0021

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a string");
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("\\u{0:X4}", (int)(input[i]));
        }
        Console.WriteLine();
    }
}
