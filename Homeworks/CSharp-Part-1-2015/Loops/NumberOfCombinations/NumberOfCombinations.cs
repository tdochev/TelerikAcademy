//Problem 7. Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose k different members out of a group of n different elements
//(also known as the number of combinations) is calculated by the following formula: formula For example,
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
//Examples:
//n 	k 	n! / (k! * (n-k)!)
//3 	2 	3
//4 	2 	6
//10 	6 	210
//52 	5 	2598960

using System;
using System.Numerics;

class NumberOfCombinations
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter k:");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNMinusK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
            if (i <= n - k)
            {
                factorialNMinusK *= i;
            }
        }
        Console.WriteLine("n! / (k! * (n-k)!) = {0}", factorialN / (factorialK * factorialNMinusK));
    }
}

