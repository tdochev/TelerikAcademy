//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//Examples:
//numbers 	sum
//1 2 3 4 5 	15
//10 10 10 10 10 	50
//1.5 3.14 8.2 -1 0 	11.84

using System;
using System.Linq;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter five numbers separated by space:");
        string [] stringArray = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;
        for (int i = 0; i < stringArray.Length; i++)
        {
            sum+= double.Parse(stringArray[i]);
        }
        Console.WriteLine("Sum: " + sum);
    }
}
