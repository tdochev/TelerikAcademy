//Problem 5. Sort by string length
//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortByStringLenght
{
    static void Main()
    {
        string[] srtringArray = { "abvd", "abc", "b", "ab","a" };
        Console.WriteLine("String array before sorting by string lenght: ");
        for (int i = 0; i < srtringArray.Length; i++)
        {
            if (i == srtringArray.Length - 1)
            {
                Console.Write(srtringArray[i]);
            }
            else
            {
                Console.Write(srtringArray[i] + ", ");
            }
        }
        Console.WriteLine();
        SortByLenght(srtringArray);
        Console.WriteLine("String array after sorting by string lenght: ");
        for (int i = 0; i < srtringArray.Length; i++)
        {
            if (i == srtringArray.Length-1)
            {
                Console.Write(srtringArray[i]);
            }
            else
            {
                Console.Write(srtringArray[i] + ", ");
            }
        }
        Console.WriteLine();
    }

    private static void SortByLenght(string[] srtringArray)
    {
        for (int i = 0; i < srtringArray.Length; i++)
        {
            for (int j = i + 1; j < srtringArray.Length; j++)
            {
                if (srtringArray[j].Length < srtringArray[i].Length)
                {
                    string swapValue = srtringArray[j];
                    srtringArray[j] = srtringArray[i];
                    srtringArray[i] = swapValue;
                }
            }
        }

    }
}
