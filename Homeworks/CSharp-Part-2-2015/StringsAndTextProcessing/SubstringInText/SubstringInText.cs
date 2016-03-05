//Problem 4. Sub-string in text
//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9

using System;

class SubstringInText
{
    static void Main()
    {
        Console.WriteLine("Please enter a text:");
        string text = Console.ReadLine();
        Console.WriteLine("Please enter a subtsring to seacrh for in the given text:");
        string substringToFind = Console.ReadLine();
        int count = 0;
        string[] textAsArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < textAsArray.Length; i++)
        {
            if (textAsArray[i].Contains(substringToFind))
            {
                for (int y = 0; y <= textAsArray[i].Length - substringToFind.Length; y++)
                {
                    if (textAsArray[i].Substring(y, substringToFind.Length) == substringToFind)
                    {
                        count++;
                    }
                }
               
            }
        }
        Console.WriteLine("The given substring appears {0} time/s", count);
    }
}