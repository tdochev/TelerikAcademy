//Problem 6. Maximal K sum
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            Console.WriteLine("Please enter value for N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for K where 0 < K <= n");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            if (n < k)
            {
                Console.WriteLine("K should be less or equal to K");
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine("The {0} elements with maximal sum are:", k);
            for (int i = 0; i < k; i++)
            {
                if (i == k - 1)
                {
                    Console.Write(array[array.Length-i-1]);
                }
                else
                {
                    Console.Write(array[array.Length - i - 1] + ", ");
                }
            }
        }
    }
}
