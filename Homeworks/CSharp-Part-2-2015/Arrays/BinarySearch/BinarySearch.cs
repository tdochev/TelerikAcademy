//Problem 11. Binary search
//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static void Main()
    {
        int[] numberArray = { 1, 3, 6, 8, 10, 12, 32, 67 };
        int arrayFirstIndex = 0;
        int arrayLastIndex = numberArray.Length - 1;
        int element = 10;
        bool elementFound = false;
        while (arrayLastIndex >= arrayFirstIndex)
        {
            int arrayMiddleIndex = arrayFirstIndex + ((arrayLastIndex - arrayFirstIndex) / 2);
            if (numberArray[arrayMiddleIndex] == element)
            {
                elementFound = true;
                Console.WriteLine(arrayMiddleIndex);
                break;
            }
            else if (numberArray[arrayMiddleIndex] < element)
            {
                arrayFirstIndex = arrayMiddleIndex + 1;
            }
            else
            {
                arrayLastIndex = arrayMiddleIndex - 1;
            }
        }
        if (elementFound == false)
        {
            Console.WriteLine("Key was not found");
        }
    }
}


