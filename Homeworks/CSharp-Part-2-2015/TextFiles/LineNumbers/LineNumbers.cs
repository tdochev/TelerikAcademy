////Problem 3. Line numbers
////Write a program that reads a text file and inserts line numbers in front of each of its lines.
////The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        string sourceFile = @"..\..\..\TextFiles\03.LineNumbers.sourceFile.txt";
        string resultFile = @"..\..\..\TextFiles\03.LineNumbers.resultFile.txt";
        StreamReader reader = new StreamReader(sourceFile);
        StreamWriter writer = new StreamWriter(resultFile);
        using (reader)
        {
            int lineCount = 1;
            string currentLineContent = reader.ReadLine();
            using (writer)
            {
                while (currentLineContent != null)
                {
                    writer.WriteLine(lineCount + "." + " " + currentLineContent);
                    currentLineContent = reader.ReadLine();
                    lineCount++;
                }
            }
        }

        Console.WriteLine("The content of \"{0}\" has been copied to \"{1}\" with appended line numbers", sourceFile, resultFile);
    }
}