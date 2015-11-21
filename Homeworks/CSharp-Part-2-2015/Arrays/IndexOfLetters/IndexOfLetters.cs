//Problem 12. Index of letters
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabetLetters = new char[26];
        for (int i = 0; i < alphabetLetters.Length; i++)
        {
            alphabetLetters[i] = Convert.ToChar(i + 65);
        }
        Console.WriteLine("Please enter a word to get the index of each letter:");
        string word = Console.ReadLine();
        foreach (var letter in word)
        {
            Console.WriteLine("{0} with index = {1} ", letter, Array.IndexOf(alphabetLetters, char.ToUpperInvariant(letter)));
        }
    }
}

