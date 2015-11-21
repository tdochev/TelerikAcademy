//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.
//Example:
//input 	result
//3, 2, 3, 4, 2, 2, 4 	2, 3, 4

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter numbers separated by comma:");
        string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] elements = new int[input.Length];
        int currentCount = 1;
        int bestCount = 1;
        for (int i = 0; i < input.Length; i++)
        {
            elements[i] = int.Parse(input[i]);
        }
        int startElement = elements[0];
        for (int i = 0; i < elements.Length - 1; i++)
        {
            if (elements[i]+1 == elements[i + 1])
            {
                if (currentCount == 1)
                {
                    startElement = elements[i];
                }
                currentCount++;
            }
            else
            {
                startElement = elements[i];
                currentCount = 1;
            }
            if (currentCount > bestCount)
            {
                bestCount = currentCount;
            }
        }
        for (int i = 0; i < bestCount; i++)
        {

            if (i == bestCount - 1)
            {
                Console.Write(startElement);
            }
            else
            {
                Console.Write(startElement + ", ");
            }
            startElement++;
        }
        Console.WriteLine();
    }
}

