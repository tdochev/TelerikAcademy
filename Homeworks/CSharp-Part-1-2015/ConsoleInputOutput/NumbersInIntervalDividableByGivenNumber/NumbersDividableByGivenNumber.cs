﻿//Problem 11.* Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
//Examples:
//start 	end 	p 	comments
//17 	    25 	    2 	20, 25
//5 	    30 	    6 	5, 10, 15, 20, 25, 30
//3 	    33 	    6 	5, 10, 15, 20, 25, 30
//3 	    4 	    0 	-
//99 	    120 	5 	100, 105, 110, 115, 120
//107 	    196 	18 	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195

using System;

class NumbersDividableByGivenNumber
{
    const int Divisor = 5;
    static void Main()
    {
        Console.WriteLine("Please enter the first number in interval of numbers:");
        uint start = uint.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the last number in interval of numbers:");
        uint end = uint.Parse(Console.ReadLine());
        uint p = 0;
        for (uint i = start; i <= end; i++)
        {
            if (i % Divisor == 0)
            {
                p += 1;
            }
        }
        Console.WriteLine("p = " + p);
    }
}
