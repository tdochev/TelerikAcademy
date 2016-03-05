////Problem 13. Count words
////Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
////The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
////Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class CountWords
{
    static void Main()
    {
        string wordsPath = @"..\..\..\TextFiles\13.CountWords.words.txt";
        string testPath = @"..\..\..\TextFiles\13.CountWords.test.txt";
        string resultPath = @"..\..\..\TextFiles\13.CountWords.result.txt";
        var fileCreateWords = new StreamWriter(wordsPath);
        ////Creates a file containig some text.
        using (fileCreateWords)
        {
            fileCreateWords.Write("words, in, file");
            Console.WriteLine("File containing list of words successfully created.", Path.GetFullPath(wordsPath));
            Console.WriteLine();
        }

        var fileCreateTest = new StreamWriter(testPath);
        using (fileCreateTest)
        {
            fileCreateTest.Write(@"Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.");
            Console.WriteLine("File containing text successfully created.", Path.GetFullPath(wordsPath));
            Console.WriteLine();
        }

        var wordsReader = new StreamReader(wordsPath);
        string[] wordsArray;
        var wordDictionary = new Dictionary<string, int>();
        try
        {
            using (wordsReader)
            {
                wordsArray = wordsReader.ReadToEnd().Split(new string[] { ", ", " ", "," }, StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < wordsArray.Length; i++)
            {
                wordDictionary.Add(wordsArray[i], 0);
            }

            var testReader = new StreamReader(testPath);
            string[] testArray;
            using (testReader)
            {
                testArray = testReader.ReadToEnd().Split(new string[] { ", ", " ", ",", ". ", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < testArray.Length; i++)
            {
                if (wordDictionary.ContainsKey(testArray[i].ToLower()))
                {
                    wordDictionary[testArray[i].ToLower()] += 1;
                }
            }

            var sortedDictionary = wordDictionary.OrderByDescending(x => x.Value);
            var resultWriter = new StreamWriter(resultPath);
            using (resultWriter)
            {
                foreach (var kvp in sortedDictionary)
                {
                    resultWriter.WriteLine("Word: {0} -  count: {1}", kvp.Key, kvp.Value);
                }

                Console.WriteLine("Result successfully saved in {0}.", Path.GetFullPath(wordsPath));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}