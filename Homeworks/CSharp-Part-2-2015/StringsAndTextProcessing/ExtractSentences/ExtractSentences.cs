//Problem 8. Extract sentences
//Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. 
//Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;

class ExtractSentences
{
    const char SentenceSeparator = '.';
    const char WordSeparator = ' ';
    static void Main()
    {
        Console.WriteLine("Please enter several sentences:");
        string input = Console.ReadLine();
        Console.WriteLine("Please enter a keyword:");
        string keyword = Console.ReadLine();
        string result = string.Empty;

        string[] sentences = input.Split(new char[] { SentenceSeparator });
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(keyword + WordSeparator) || sentences[i].Contains(WordSeparator + keyword))
            {
                result += sentences[i] + SentenceSeparator;
            }
        }
        Console.WriteLine("The sentences containig {0} are: \n{1}", keyword, result);
    }
}

