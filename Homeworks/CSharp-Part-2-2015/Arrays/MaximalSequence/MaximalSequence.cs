//Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.
//Example:
//input 	                    result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1 	2, 2, 2

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter numbers separated by comma:");
        string[] input = Console.ReadLine().Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        int[] elements = new int[input.Length];
        int currentCount = 1;
        int bestCount = 1;
        int bestElement = 0;
        for (int i = 0; i < input.Length; i++)
        {
            elements[i] = int.Parse(input[i]);
        }
        for (int i = 0; i < elements.Length-1; i++)
        {
            if (elements[i] == elements[i + 1])
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }
            if (currentCount >= bestCount)
            {
                bestCount = currentCount;
                bestElement = elements[i];
            }
        }
        for (int i = 0; i < bestCount; i++)
        {
            
            if (i == bestCount - 1)
            {
                Console.Write(bestElement);
            }
            else
            {
                Console.Write(bestElement + ", ");
            }
        }
        Console.WriteLine();
    }
}
