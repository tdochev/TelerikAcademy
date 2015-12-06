//Problem 6. Sum integers
//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:
//input 	output
//"43 68 9 23 318" 	461

using System;

class SumIntegers
{
    static double SumValuesInString(string input)
    {
        double sum = 0;
        string[] inputArray = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < inputArray.Length; i++)
        {
            sum += double.Parse(inputArray[i]);
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine("Please enter a sequence of positive integer values, separated by spaces");
        string input = Console.ReadLine();
        Console.WriteLine("The sum of the entered sequence is: {0}", SumValuesInString(input));
    }
}

