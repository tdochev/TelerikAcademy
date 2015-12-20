//Problem 20. Palindromes
//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;

class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Please enter a text to extract all palindromes:");
        string[] inputAsArray = Console.ReadLine().Split(new[] { " ", "." }, StringSplitOptions.RemoveEmptyEntries);
        bool isPalindrome = true;
        for (int i = 0; i < inputAsArray.Length; i++)
        {
            for (int y = 0; y < inputAsArray[i].Length; y++)
            {
                if (char.ToLower(inputAsArray[i][y]) != (char.ToLower(inputAsArray[i][inputAsArray[i].Length - 1 - y])))
                {
                    isPalindrome = false;
                    break;
                }
                isPalindrome = true;
            }
            if (isPalindrome)
            {
                Console.WriteLine(inputAsArray[i]);
            }
        }
    }
}
