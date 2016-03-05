////Problem 2. Concatenate text files
////Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        string firstFilePath = @"..\..\..\TextFiles\02.ConcatenateTextFiles.firstFile.txt";
        string secondFilePath = @"..\..\..\TextFiles\02.ConcatenateTextFiles.secondFile.txt";
        string resultPath = @"..\..\..\TextFiles\02.ConcatenateTextFiles.resultFile.txt";
        string firstFileContents = string.Empty;
        string secondFileContents = string.Empty;
        StreamReader firstFileReader = new StreamReader(firstFilePath);
        StreamReader secondFileReader = new StreamReader(secondFilePath);
        using (firstFileReader)
        {
            firstFileContents = firstFileReader.ReadToEnd();
        }

        using (secondFileReader)
        {
            secondFileContents = secondFileReader.ReadToEnd();
        }

        StreamWriter resultWriter = new StreamWriter(resultPath);
        using (resultWriter)
        {
            resultWriter.Write("The concatenated contents of the given files is: " + firstFileContents + " " + secondFileContents);
        }

        Console.WriteLine("The content of \"{0}\" and \"{1}\" have been concatenated and copied to \"{2}\"", firstFilePath, secondFilePath, resultPath);
    }
}