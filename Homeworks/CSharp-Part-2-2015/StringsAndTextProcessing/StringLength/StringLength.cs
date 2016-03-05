//Problem 6. String length
//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Please enter a string no longer than 20 charachters:");
        string input = Console.ReadLine();
        while (input.Length > 20)
        {
            Console.WriteLine("The string entered is longer than 20 charachters!\nPlease enter another one: " );
            input = Console.ReadLine();
        }
        if (input.Length < 20)
        {
            input = input.PadRight(20, '*');
        }
        Console.WriteLine("The result is:\n{0}", input);
    }
}
