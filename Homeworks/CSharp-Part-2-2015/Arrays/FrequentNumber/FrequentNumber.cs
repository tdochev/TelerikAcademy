//Problem 9. Frequent number
//Write a program that finds the most frequent number in an array.
//Example:
//input 	result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)


using System;

    class FrequentNumber
    {
        static void Main()
        {
            int[] numbersArray = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            Array.Sort(numbersArray);
            int currentNumberCount = 1;
            int bestNumber = 0;
            int bestNumberCount = 0;
            for (int i = 1; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == numbersArray[i - 1])
                {
                    currentNumberCount++;
                }
                else
                {
                    currentNumberCount = 1;
                }
                if (currentNumberCount > bestNumberCount)
                {
                    bestNumber = numbersArray[i];
                    bestNumberCount = currentNumberCount;
                }
            }
            Console.WriteLine("{0} ({1} times)",bestNumber, bestNumberCount);
        }
    }

