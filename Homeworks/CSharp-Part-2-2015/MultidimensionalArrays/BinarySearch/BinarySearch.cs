//Problem 4. Binary search
//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method
//Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Please enter the lenght of your array:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter the {0} number in the array:", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please enter value for K:");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(numbers);
        int indexdOfK = Array.BinarySearch(numbers, k);
        int result;
        if (indexdOfK == -1)
        {
            Console.WriteLine("There is no smaller or eqaul to K number in the array");

        }
        else if (indexdOfK < 0)
        {
            result = numbers[~indexdOfK - 1];
            Console.WriteLine("The largest number <= K (K={0}) is : {1}", k, result);
        }
        else
        {
            result = numbers[indexdOfK];
            Console.WriteLine("The largest number <= K (K={0}) is : {1}", k, result);
        }
    }
}

