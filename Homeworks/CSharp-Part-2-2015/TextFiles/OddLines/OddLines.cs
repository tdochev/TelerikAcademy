////Problem 1. Odd lines
////Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\..\TextFiles\01.OddLines.txt");
        using (reader)
        {
            int lineNumber = 1;
            string line = string.Empty;
            while (line != null)
            {
                line = reader.ReadLine();
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine(line);
                }

                lineNumber++;
            }
        }
    }
}