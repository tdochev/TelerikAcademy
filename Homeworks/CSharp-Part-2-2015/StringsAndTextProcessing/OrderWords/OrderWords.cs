//Problem 24. Order words
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Pleas enter a list of words separated by spaces:");
        string[] inputAsArray = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(inputAsArray);
        Console.WriteLine("Your sorted list: {0}" ,String.Join(" ", inputAsArray));
    }
}

