//Problem 3. Min, Max, Sum and Average of N Numbers
//Write a program that reads from the console a sequence of n integer numbers and returns
//the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
//Example 1:
//input 	output
//3
//2
//5
//1 	min = 1
//max = 5
//sum = 8
//avg = 2.67
//Example 2:
//input 	output
//2
//-1
//4 	min = -1
//max = 4
//sum = 3
//avg = 1.50

using System;

class MinMaxSumAndAverage
{
    static void Main()
    {
        int min = 0;
        int max = 0;
        int sum = 0;
        double avg = 0;
        Console.WriteLine("Please enter n folowed by n numbers");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (i == 0)
            {
                min = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        avg = sum / n;
        Console.WriteLine("min = {0} \nmax = {1} \nsum = {2} \navg = {3:f2}",min ,max, sum, avg);
    }
}


