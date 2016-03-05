////Problem 4. Compare text files
////Write a program that compares two text files line by line and prints the number of lines
////that are the same and the number of lines that are different.
////Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        string firstFilePath = @"..\..\..\TextFiles\04.CompareTextFiles.firstFile.txt";
        string secondFilePath = @"..\..\..\TextFiles\04.CompareTextFiles.secondFile.txt";
        StreamReader firstFileReader = new StreamReader(firstFilePath);
        StreamReader secondFileReader = new StreamReader(secondFilePath);
        int sameLines = 0;
        int differentLines = 0;
        using (firstFileReader)
        {
            using (secondFileReader)
            {
                string firstFileCurrentLine = firstFileReader.ReadLine();
                string secondFileCurrentLine = secondFileReader.ReadLine();
                while (firstFileCurrentLine != null)
                {
                    if (firstFileCurrentLine == secondFileCurrentLine)
                    {
                        sameLines++;
                    }
                    else
                    {
                        differentLines++;
                    }

                    firstFileCurrentLine = firstFileReader.ReadLine();
                    secondFileCurrentLine = secondFileReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Number of line that are the same: {0}\nNumber of line that are different: {1}", sameLines, differentLines);
    }
}