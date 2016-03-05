//Problem 13. Reverse sentence
//Write a program that reverses the words in given sentence.
//Example:
//input 	                                output
//C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!

using System;
using System.Text;
using System.Linq;

class ReverseSentence
{
    static void Main()
    {
        Console.WriteLine("Please enter a sentence to reverse the words in it.");
        string sentence = Console.ReadLine();
        StringBuilder result = new StringBuilder(sentence.Length);
        StringBuilder word = new StringBuilder();
        char[] endOfSentence = { '!','?', '.' };
        char[] punctuation = { ',' };
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ' && !endOfSentence.Contains(sentence[i]) && !punctuation.Contains(sentence[i]))
            {
                word.Append(sentence[i]);
            }
            else
            {
                word.Append(" ");
                result.Insert(0, word);
                word.Clear();
            }
            if (endOfSentence.Contains(sentence[i]))
            {
                 result.Append(sentence[i]);
                 result.Remove(sentence.Length - 1, 1);
            }
        }
        Console.WriteLine(result);
    }
}
