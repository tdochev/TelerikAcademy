//Problem 2. Random numbers
//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static void Main()
    {
        const int valuesCount = 10;
        Console.WriteLine("Generating rnadom numbers in the range [100, 200]");
        Random generator = new Random();
        for (int i = 0; i < valuesCount; i++)
        {
            Console.Write(generator.Next(100, 201));
            if (i != valuesCount-1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
