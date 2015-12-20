//Problem 5. Parse tags
//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;

class ParseTags
{
    const string openTag = "upcase";
    const string closeTag = "/upcase";
    static void Main()
    {
        Console.WriteLine("Please enter a text to parse tags: ");
        string text = Console.ReadLine();
        string[] textArray = text.Split(new char[] { '<', '>' });
        for (int i = 0; i < textArray.Length; i++)
        {
            if (textArray[i] == openTag)
            {
                textArray[i] = string.Empty;
                textArray[i + 1] = textArray[i + 1].ToUpper();
            }
            if (textArray[i] == closeTag)
            {
                textArray[i] = string.Empty;
            }
        }
        Console.WriteLine("The result is:\n" + string.Join(string.Empty, textArray));
    }
}

