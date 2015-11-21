//Problem 15. Prime numbers
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {
        int firstPrimeNumber = 2;
        int allPrimeTo = 100;
        bool[] isPrime = new bool[allPrimeTo + 1];
        for (int i = firstPrimeNumber; i * i <= allPrimeTo; i++)
        {
            if (!isPrime[i])
            {
                for (int j = i * i; j < isPrime.Length; j += i)
                {
                    isPrime[j] = true;
                }

            }
        }

        for (int i = firstPrimeNumber; i < isPrime.Length; i++)
        {
            if (isPrime[i] == false)
            {
                Console.Write("{0}, ", i);
            }
        }
        Console.WriteLine();
    }
}

