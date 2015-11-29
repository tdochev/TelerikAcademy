//Problem 9. Sorting array
//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;

class SortingArray
{
    static int FindMaxElelemtIndex(int startInex, int[] array)
    {
        int result = int.MinValue;
        int maximalElementIndex = 0;
        for (int i = startInex; i < array.Length; i++)
        {
            if (array[i] > result)
            {
                result = array[i];
                maximalElementIndex = i;
            }
        }
        return maximalElementIndex;
    }
    static int[] SortDescending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int indexOfBiggest = FindMaxElelemtIndex(i, array);
            int swapValue = array[i];
            array[i] = array[indexOfBiggest];
            array[indexOfBiggest] = swapValue;
        }
        return array;
    }
    static int[] SortAscending(int[] array)
    {
        SortDescending(array);
        for (int i = 0; i < array.Length/2; i++)
        {
            int swapValue = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = swapValue;
        }
        return array;
    }
    static void Main()
    {
        int[] NumbersArray = { 75, 2, 5, 1, 8, 73, 9 };
        Console.WriteLine("Array before sorting: {0}", string.Join(", ", NumbersArray));
        Console.WriteLine("Array after sorting it in asceding order: {0}", string.Join(", ", SortAscending(NumbersArray)));
        Console.WriteLine("Array after sorting it in descending order: {0}", string.Join(", ", SortDescending(NumbersArray)));
    }

}

