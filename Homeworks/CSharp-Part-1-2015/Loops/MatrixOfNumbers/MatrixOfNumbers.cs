﻿//Problem 9. Matrix of Numbers
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
//and prints a matrix like in the examples below. Use two nested loops.
//Examples:
//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1 2 3 4
//        2 3                 2 3 4               2 3 4 5
//                            3 4 5               3 4 5 6
//                                                4 5 6 7


using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                Console.Write(row + col);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

