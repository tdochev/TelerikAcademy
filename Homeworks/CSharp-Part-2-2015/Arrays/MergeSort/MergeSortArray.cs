//Problem 13.* Merge sort
//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

namespace MergeSort
{
    class MergeSortArray
    {

        void mergeArray(int[] array, int start, int mid, int end)
        {
            int[] tempArray = new int[end - start + 1];
            int i = start;
            int j = mid + 1;
            int k = 0;
            while (start <= mid && j <= end)
            {
                if (array[i] < array[j])
                {
                    tempArray[k] = array[i];
                    k++;
                    i++;
                }
                else
                {
                    tempArray[k] = array[j];
                    k++;
                    j++;
                }
            }
            while (i <= mid)
            {
                tempArray[k] = array[i];
                k++;
                i++;
            }
            while (j <= end)
            {
                tempArray[k] = array[j];
                k++;
                j++;
            }
            k = 0;
            i = start;
            while (k < tempArray.Length && i <= end)
            {
                array[i] = tempArray[k];
                i++;
                k++;
            }
        }
        void MergeSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2;
                MergeSort(array, start, mid);
                MergeSort(array, mid + 1, end);
                mergeArray(array, start, mid, end);

            }
        }
        static void Main()
        {
            int[] arrayForMergeSort = { 122, 352, 182, 3, 6, 4, 215, 10, 87, 14 };
            MergeSortArray sortedArray = new MergeSortArray();
            sortedArray.MergeSort(arrayForMergeSort, 0, arrayForMergeSort.Length - 1);

            foreach (var item in arrayForMergeSort)
            {
                Console.WriteLine(item);
            }
        }
    }
}


