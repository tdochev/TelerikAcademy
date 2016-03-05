////Problem 11. Prefix "test"
////Write a program that deletes from a text file all words that start with the prefix test.
////Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.IO;

class PrefixTest
{
    const string WordToRemove = "test";
   
    static void Main()
    {
        string path = @"..\..\..\TextFiles\11.PrefixTest.inputOutput.txt";
        string tempFile = Path.GetTempFileName();
        var writerToTempFile = new StreamWriter(tempFile);
        var writer = new StreamWriter(path);
        ////Generate temporary data
        using (writer)
        {
            writer.WriteLine("Test testA testa test_b test_ test, test9 test!");
            Console.WriteLine("Input text file successfully created:\n{0}", Path.GetFullPath(path));
        }

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
                        if (words[i].Length > 4 && words[i].Substring(0, 4) == WordToRemove && 
                            (char.IsLetterOrDigit(words[i][4]) || words[i][4] == '_'))
                        {
                            words[i] = words[i].Substring(4, words[i].Length - words[i].Substring(0, 4).Length);
                        }
                    }

                    writerToTempFile.WriteLine(string.Join(" ", words));
                    currentLine = reader.ReadLine();
                }
            }

            Console.WriteLine(@"All words that start with the prefix ""test"" have been delted from the file.");
        }
        
        File.Delete(path);
        File.Move(tempFile, path);
    }
}