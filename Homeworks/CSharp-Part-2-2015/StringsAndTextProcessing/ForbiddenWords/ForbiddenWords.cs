//Problem 9. Forbidden words
//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Forbidden words: PHP, CLR, Microsoft
//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;

class ForbiddenWords
{
    static string[] ForbidenWords = {"PHP", "CLR", "Microsoft"};
    static void Main()
    {
        Console.WriteLine("Please enter forbiden words separated by comma:");
        string[] forbidenWords = Console.ReadLine().Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Please enter a some sentances to replace forbiden words with * :");
        string words = Console.ReadLine();
        for (int i = 0; i < ForbidenWords.Length; i++)
        {
            words = words.Replace(ForbidenWords[i], new string('*', ForbidenWords[i].Length));
        }
        Console.WriteLine(words);
    }
}
