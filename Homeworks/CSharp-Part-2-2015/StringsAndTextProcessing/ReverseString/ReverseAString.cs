//Problem 2. Reverse string
//Write a program that reads a string, reverses it and prints the result at the console.
//Example:
//input 	output
//sample 	elpmas

using System;
using System.Text;

class ReverseAString
{
    static string ReverseString(string stringToReverse)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < stringToReverse.Length; i++)
        {
            result.Append(stringToReverse[stringToReverse.Length - i -1]); 
        }
        return result.ToString();
    }
    static void Main()
    {
        Console.WriteLine("please eneter a string to reverse it: ");
        string input = Console.ReadLine();
        string stringReversed = ReverseString(input);
        Console.WriteLine("Your reversed string is: {0}", stringReversed);
    }
}
