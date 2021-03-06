﻿//Problem 11. Random Numbers in Given Range
//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
//Examples:
//n 	min 	max 	random numbers
//5 	0 	1 	1 0 0 1 1
//10 	10 	15 	12 14 12 15 10 12 14 13 13 11
//
//Note: The above output is just an example. Due to randomness, your program most probably will produce different results.

using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Please enter how many random numbers woul you like to print:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the minimal value of the random numbers:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the maximal value of the random numbers:");
        int max = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        Console.WriteLine("Your random numbers are: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(randomGenerator.Next(min,max+1));
            Console.Write(" ");
        }
    }
}

