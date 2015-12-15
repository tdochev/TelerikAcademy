//Problem 2. Enter numbers
//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class Numbers
{
    static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Please enter a number in the given range [{0} {1}]" ,start,end);
        int input = 0;
        try
        {
            input = int.Parse(Console.ReadLine());
            if (input <= start || input >= end )
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return input;
    }
    static void Main()
    {
        Console.WriteLine("Please enter 10 numbers so that n1, n2, … n10, such that 1 < n1 < … < n10 < 100");
        int [] numbersArray = new int[10];
        int start = 1;
        int end = 100;
        for (int i = 0; i < 10; i++)
        {
            numbersArray[i] = ReadNumber(start, end);
            start = numbersArray[i];
        }
    }
}
