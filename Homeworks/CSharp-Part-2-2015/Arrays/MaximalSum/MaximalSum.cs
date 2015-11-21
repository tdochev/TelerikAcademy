//Problem 8. Maximal sum
//Write a program that finds the sequence of maximal sum in given array.
//Example:
//input 	result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class MaximalSum
{
    static void Main()
    {
        int[] numbersArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int startIndex = 0;
        int stopIndex = 0;
        int currentStartIndex = 0;
        int currentSum = numbersArray[0];
        int bestSum = numbersArray[0];
        for (int i = 1; i < numbersArray.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = numbersArray[i];
                currentStartIndex = i;
            }
            else
            {
                currentSum += numbersArray[i];
            }
            if (currentSum >bestSum )
            {
                bestSum = currentSum;
                startIndex = currentStartIndex;
                stopIndex = i;
            }
        }
        for (int i = startIndex; i < stopIndex; i++)
        {
            if (i < stopIndex-1)
            {
                Console.Write(numbersArray[i] + ",");
            }
            else
            {
                Console.Write(numbersArray[i]);
            }
        }
        Console.WriteLine();
    }
}

