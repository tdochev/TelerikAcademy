//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.
//Examples:
//n 	Odd?
//3 	true
//2 	false
//-2 	false
//-1 	true
//0 	false

using System;


class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number to check if it is odd");
        int n = Convert.ToInt32(Console.ReadLine());
        bool isOdd = n % 2 != 0;
        Console.WriteLine("{0,-2}  -  {1,-6}", n, isOdd);

    }
}


