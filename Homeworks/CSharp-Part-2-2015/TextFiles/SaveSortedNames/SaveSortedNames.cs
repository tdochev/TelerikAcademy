////Problem 6. Save sorted names
////Write a program that reads a text file containing a list of strings,
////sorts them and saves them to another text file.
////Example:
////input.txt     output.txt
////Ivan          George
////Peter         Ivan
////Maria         Maria
////George        Peter

using System;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        string inputPath = @"..\..\..\TextFiles\06.SaveSortedNames.input.txt";
        string outputPath = @"..\..\..\TextFiles\06.SaveSortedNames.output.txt";
        var fileCreator = new StreamWriter(inputPath);
        ////Creates the input file
        using (fileCreator)
        {
            fileCreator.WriteLine("Ivan");
            fileCreator.WriteLine("Peter");
            fileCreator.WriteLine("Maria");
            fileCreator.WriteLine("George");
            Console.WriteLine("Input file created:\n{0}\n", Path.GetFullPath(inputPath));
        }

        StreamReader inputReader = new StreamReader(inputPath);
        StreamWriter outputWriter = new StreamWriter(outputPath);
        string[] inputArray;
        using (inputReader)
        {
            inputArray = inputReader.ReadToEnd().Split(new string[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Input file successfully read.\n");
        }

        Array.Sort(inputArray);
        using (outputWriter)
        {   
            outputWriter.Write(string.Join(Environment.NewLine, inputArray));
            Console.WriteLine("Result saved in:\n{0}", Path.GetFullPath(inputPath));
        }
    }
}