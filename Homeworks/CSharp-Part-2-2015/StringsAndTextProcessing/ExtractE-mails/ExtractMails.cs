//Problem 18. Extract e-mails
//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;

class ExtractMails
{
    static void Main()
    {
        Console.WriteLine("Please enter some textx to extract all e-mails from it: ");
        string[] words = Console.ReadLine().Split(new [] {" ", ".\""}, StringSplitOptions.RemoveEmptyEntries);
        bool emailFound = false;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains("@") && (words[i].Contains(".")))
            {
                string identifier = words[i].Substring(0, words[i].IndexOf('@'));
                string hostAndDomain = words[i].Substring(words[i].IndexOf('@'), words[i].Length - words[i].IndexOf('@'));
                if (identifier.Length < 1 || hostAndDomain.IndexOf('.') == hostAndDomain.Length-1)
                {
                    break;
                }
                else
                {
                    emailFound = true;
                    Console.WriteLine(words[i]);
                }
            }
        }
        if (emailFound == false)
        {
            Console.WriteLine("No e-mails found.");
        }
    }
}

