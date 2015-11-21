//Problem 14. Quick sort
//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;

class QuickSortArray
{
    static private int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
            {
                left++;
            }
            while (numbers[right] > pivot)
            {
                right--;
            }
            if (numbers[right] == pivot && numbers[left] == pivot)
            {
                left++;
            }
            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        } 

    }
    static private void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
            QuickSort(arr, left, pivot - 1);
            QuickSort(arr, pivot + 1, right);
        }
    }
    static void Main()
    {
        Random randomNumber = new Random();
        int[] numbersForSort = new int[11];
        Console.WriteLine("Array before Quick sort");
        for (int i = 0; i < numbersForSort.Length; i++)
        {
            numbersForSort[i] = randomNumber.Next(0, 100);
            if (i < numbersForSort.Length - 1)
            {
                Console.Write(numbersForSort[i] + ", ");
            }
            else
            {
                Console.Write(numbersForSort[i]);
            }
        }
        Console.WriteLine();
        QuickSort(numbersForSort, 0, numbersForSort.Length -1);
        Console.WriteLine("Array after Quick sort:");
        for (int i = 0; i < numbersForSort.Length; i++)
        {
            if (i < numbersForSort.Length - 1)
            {
                Console.Write(numbersForSort[i] + ", ");
            }
            else
            {
                Console.Write(numbersForSort[i]);
            }
        }
        Console.WriteLine();
    }
}
