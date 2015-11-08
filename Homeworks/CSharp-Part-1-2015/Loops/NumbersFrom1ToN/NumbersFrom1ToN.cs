//Problem 1. Numbers from 1 to N
//Write a program that enters from the console a positive integer n
//and prints all the numbers from 1 to n, on a single line, separated by a space.
//Examples:
//n 	output
//3 	1 2 3
//5 	1 2 3 4 5

using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Please enter n in order to print all number from 1 to n");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            if (i!=n)
            {
                Console.Write(i + " ");
            }
            else
            {
                Console.Write(i);
            }
        }
        Console.WriteLine();
    }
}

