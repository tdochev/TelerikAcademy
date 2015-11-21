//Problem 10. Find sum in array
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:
//array 	S 	result
//4, 3, 1, 4, 2, 5, 8 	11 	4, 2, 5

using System;

class FindSumInArray
{
    static void Main()
    {
        const int Sum = 11;
        bool sumFound = false;
        int[] numbersArray = new int[] { 4, 3, 1, 4, 2, 5, 8 };
        for (int i = 0; i < numbersArray.Length; i++)
        {
            int currentSum = 0;
            for (int j = i; j < numbersArray.Length; j++)
            {
                currentSum += numbersArray[j];
                if (currentSum==Sum)
                {
                    sumFound = true;
                    currentSum = 0;
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(numbersArray[k] + ",");
                    }
                    Console.WriteLine();
                }
                if (currentSum > Sum)
                {
                    currentSum = 0;
                    break;
                }
            }
        }
        if (sumFound == false)
        {
            Console.WriteLine("There are no numbers in the array that can sum up to {0}", Sum);
        }
    }
}

