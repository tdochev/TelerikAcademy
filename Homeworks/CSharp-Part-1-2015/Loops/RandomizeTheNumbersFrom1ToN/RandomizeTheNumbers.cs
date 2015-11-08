//Problem 12.* Randomize the Numbers 1…N
//    Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
//Examples:
//n 	randomized numbers 1…n
//3 	2 1 3
//10 	3 4 8 2 6 7 9 1 10 5
//
//Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.

using System;

class RandomizeTheNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int[] numbers = new int[n];
        int[] result = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i+1;
        }
        for (int i = n-1; i >= 0; i--)
        {
            int temp = randomGenerator.Next(0, i+1);
            result[i] = numbers[temp];
            numbers[temp] = numbers[i];
            Console.WriteLine(result[i]);
        }
    }
}

