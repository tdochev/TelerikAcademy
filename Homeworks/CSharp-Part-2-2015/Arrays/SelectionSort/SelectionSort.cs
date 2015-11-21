//Problem 7. Selection sort
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        int min = 0;
        int[] arrayToSort = { 64, 25, 12, 22, 11 };
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            Console.Write(arrayToSort[i]+",");
        }
        for (int i = 0; i < arrayToSort.Length-1; i++)
        {
            min = i;
            for (int j = i+1; j < arrayToSort.Length; j++)
            {
                if (arrayToSort[j] < arrayToSort[min])
                {
                    min = j;
                }
            }
            int swapIndex = arrayToSort[i];
            arrayToSort[i] = arrayToSort[min];
            arrayToSort[min] = swapIndex;
        }
        Console.WriteLine();
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            Console.Write(arrayToSort[i] + ",");
        }
    }
}

