////Problem 12. Remove words
////Write a program that removes from a text file all words listed in given another text file.
////Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class RemoveWords
{
    static void Main()
    {
        string path = @"..\..\..\TextFiles\12.RemoveWords.inputOutput.txt";
        string pathOfWordsToRemove = @"..\..\..\TextFiles\12.RemoveWords.words.txt";
        string tempFile = Path.GetTempFileName();
        var fileCreate = new StreamWriter(path);
        ////Creates a file containig some text.
        using (fileCreate)
        {
            fileCreate.Write("I'am learning C# in Telerik Academy this year.");
            Console.WriteLine("File {0} successfully created.", Path.GetFullPath(path));
            Console.WriteLine();
        }
        ////Creates a file containig the words which will be removed.
        var wordFileCreate = new StreamWriter(pathOfWordsToRemove);
        using (wordFileCreate)
        {
            wordFileCreate.Write(@"C# Telerik Academy");
            Console.WriteLine("File {0} successfully created.", Path.GetFullPath(pathOfWordsToRemove));
            Console.WriteLine();
        }

        var wordsReader = new StreamReader(pathOfWordsToRemove);
        string[] wordsToRemove;
        using (wordsReader)
        {
            wordsToRemove = wordsReader.ReadToEnd().Split(' ');
            Console.WriteLine("File containing words that have to be removed was successfully read.\nThe words are:\n{0}\n", string.Join(" ", wordsToRemove));
        }

        try
        {
            var writerToTempFile = new StreamWriter(tempFile);
            var reader = new StreamReader(path);
            using (reader)
            {
                string currentLine = reader.ReadLine();
                using (writerToTempFile)
                {
                    while (currentLine != null)
                    {
                        string[] words = currentLine.Split(' ');
                        for (int i = 0; i < words.Length; i++)
                        {
                            for (int y = 0; y < wordsToRemove.Length; y++)
                            {
                                if (words[i] == wordsToRemove[y])
                                {
                                    words[i] = string.Empty;
                                }
                            }
                        }

                        writerToTempFile.WriteLine(string.Join(" ", words.Where(s => !string.IsNullOrEmpty(s))));
                        currentLine = reader.ReadLine();
                    }

                    Console.WriteLine("Listed words successfully removed.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        File.Delete(path);
        File.Move(tempFile, path);
    }
}