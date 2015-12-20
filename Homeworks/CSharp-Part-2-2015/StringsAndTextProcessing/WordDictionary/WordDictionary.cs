//Problem 14. Word dictionary
//
//    A dictionary is stored as a sequence of text lines containing words and their explanations.
//    Write a program that enters a word and translates it by using the dictionary.
//
//Sample dictionary:
//input 	output
//.NET 	platform for applications from Microsoft
//CLR 	managed execution environment for .NET
//namespace 	hierarchical organization of classes

using System;
using System.Collections.Generic;


namespace WordDictionary
{
    class WordDictionary
    {
        static void Main()
        {
            Dictionary<string, string> wordDictionary = new Dictionary<string, string>();
            wordDictionary.Add(".NET", "platform for applications from Microsoft");
            wordDictionary.Add("CLR", "managed execution environment for .NET");
            wordDictionary.Add("namespace", "hierarchical organization of classes");
            Console.WriteLine("Please enter a word to secrh our dictionary:");
            string input = Console.ReadLine();
            if (wordDictionary.ContainsKey(input))
            {
                Console.WriteLine(wordDictionary[input]);
            }
            else
            {
                Console.WriteLine("No such word in the dictionary.");
            }
            Console.WriteLine();
        }
    }
}
