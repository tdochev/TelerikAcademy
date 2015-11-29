//Problem 14. Integer calculations
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;
using System.Linq;

    class IntegerCalculations
    {
        static int Minimum(int[] input)
        {
            int min = int.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < min)
                {
                    min = input[i];
                }
            }
            return min;

        }
        static int Maximum(int[] input)
        {
            int max = int.MinValue;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > max)
                {
                    max = input[i];
                }
            }
            return max;
        }
        static decimal Average(int[] input)
        {
            return (decimal)Sum(input) / input.Length;
        }
        static int Sum(int[] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }
        static long Product(int[] input)
        {
            long product = 1;
            for (int i = 0; i < input.Length; i++)
            {
                product *= input[i];
            }
            return product;
        }
        static void Main()
        {
            Console.WriteLine("Enter a sequence of integers, separated by spaces and/or commas: ");
            int[] input = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine("Min: {0}\nMax: {1}\nAverage: {2:f2}\nSum: {3}\nProduct: {4}", Minimum(input), Maximum(input),(decimal)Average(input),Sum(input), Product(input));
        }

    }
