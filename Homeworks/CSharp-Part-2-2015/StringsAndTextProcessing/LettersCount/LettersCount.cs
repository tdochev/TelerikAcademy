//Problem 21. Letters count
//Write a program that reads a string from the console and prints all different letters in the string
//along with information how many times each letter is found.

using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        Console.WriteLine("Please enter a string to count the occurence of each letter: ");
        string input = Console.ReadLine();
        Dictionary<char,int> result = new Dictionary<char,int>();
        foreach (var charater in input)
        {
            if (char.IsLetter(charater))
            {
                if (result.ContainsKey(char.ToLower(charater)))
                {
                    result[char.ToLower(charater)] += 1;
                }
                else
                {
                    result.Add(char.ToLower(charater), 1);
                }
            }
        }
        foreach (var kvp in result)
        {
            Console.WriteLine("Letter: {0}, Count: {1}", kvp.Key, kvp.Value);
        }
    }
}
