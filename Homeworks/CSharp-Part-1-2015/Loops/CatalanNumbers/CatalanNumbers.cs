//Problem 8. Catalan Numbers
//    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//    Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
//Examples:
//n 	Catalan(n)
//0 	1
//5 	42
//10 	16796
//15 	9694845

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorial2N = 1;
        BigInteger factorialnPlus1 = 1;
        for (int i = 1; i <= 2 * n; i++)
        {
            factorial2N *= i;
            if (i <= n)
            {
                factorialN *= i;
            }
            if (i <= n+1)
            {
                factorialnPlus1 *= i;
            }
        }
        Console.WriteLine("Catalan({0}) = (2n)! / (n +1)!n!) = {1}",n, factorial2N / (factorialnPlus1 * factorialN));
    }
}

