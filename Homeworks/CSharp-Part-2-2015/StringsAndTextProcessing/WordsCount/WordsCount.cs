//Problem 22. Words count
//Write a program that reads a string from the console and lists all different words in the string
//along with information how many times each word is found.

using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        Console.WriteLine("Please enter a string to count the occurence of each word: ");
        string[] input = Console.ReadLine().Split(new[] {" ",".",","}, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> result = new Dictionary<string, int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (result.ContainsKey(input[i].ToLower()))
                {
                    result[input[i].ToLower()] += 1;
                }
                else
                {
                    result.Add(input[i].ToLower(), 1);
                }
            }
        foreach (var kvp in result)
        {
            Console.WriteLine("Word: {0} -  Count: {1}", kvp.Key, kvp.Value);
        }
       ;
    }
}