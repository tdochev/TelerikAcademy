//Problem 6. Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
//Examples:
//n 	k 	n! / k!
//5 	2 	60
//6 	5 	6
//8 	3 	6720

using System;

class FactorialDivision
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter k:");
        int k = int.Parse(Console.ReadLine());
        int factorialN = 1;
        int factorialK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }
        Console.WriteLine("n! / k! = {0}", factorialN/factorialK);
    }
}

