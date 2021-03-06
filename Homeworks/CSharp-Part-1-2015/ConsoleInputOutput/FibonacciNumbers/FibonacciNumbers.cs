﻿//Problem 10. Fibonacci Numbers
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.
//Examples:
//n 	comments
//1 	0
//3 	0 1 1
//10 	0 1 1 2 3 5 8 13 21 34

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter the count (n) to see the first n members of the Fibonacci sequence");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        for (int i = 0; i < n; i++)
        {
            int current = a;
            if (i == n-1)
            {
              Console.WriteLine(current);  
            }
            else
            {
                Console.Write(current + ", ");
            }
            a = b;
            b = current + b;
        }
    }
}

