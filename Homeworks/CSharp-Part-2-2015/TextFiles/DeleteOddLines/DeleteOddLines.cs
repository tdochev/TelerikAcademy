////Problem 9. Delete odd lines
////Write a program that deletes from given text file all odd lines.
////The result should be in the same file.

using System;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        string path = @"..\..\..\TextFiles\09.DeleteOddLines.inputOutput.txt";
        string tempFile = Path.GetTempFileName();
        var writerToTempFile = new StreamWriter(tempFile);
        var writer = new StreamWriter(path);
        ////insert some lines in the file
        using (writer)
        {
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    writer.WriteLine("{0}. Even line", i);
                }
                else
                {
                    writer.WriteLine("{0}. Odd line", i);
                }
            }

            Console.WriteLine("Input file successfully created:\n{0}", Path.GetFullPath(path));
        }
        ////delete odd lines
        var reader = new StreamReader(path);
        using (reader)
        {
            string currentLine = reader.ReadLine();
            int lineCount = 1;
            using (writerToTempFile)
            {
                while (currentLine != null)
                {
                    if (lineCount % 2 == 0)
                    {
                        writerToTempFile.WriteLine(currentLine);
                    }

                    currentLine = reader.ReadLine();
                    lineCount++;
                }
            }

            Console.WriteLine("All odd lines have been deleted from the file.");
        }

        File.Delete(path);
        File.Move(tempFile, path);
    }
}
