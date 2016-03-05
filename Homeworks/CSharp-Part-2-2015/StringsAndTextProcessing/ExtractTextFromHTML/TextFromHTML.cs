using System;
using System.Text;

class TextFromHTML
{
    static void Main()
    {
        Console.WriteLine("Please enter an html to extract text from it:");
        string input = Console.ReadLine();
        string title = string.Empty;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 7 && input.Substring(i, 7) == "<title>")
            {
                i += 7;
                while (input[i] != '<')
                {
                    title += input[i];
                    i++;
                }
            }
            if (input[i] == '<')
            {
                while (input[i] != '>')
                {
                    i++;
                }
            }
            if (i < input.Length && input[i] != '>')
            {
                result.Append(input[i]);
            }
            if (input[i] == '>')
            {
                result.Append(" ");
            }
        }
        string text = result.ToString().Trim();
        Console.WriteLine("Title: {0}\nText: {1}", title, result.ToString().Trim());

    }
}