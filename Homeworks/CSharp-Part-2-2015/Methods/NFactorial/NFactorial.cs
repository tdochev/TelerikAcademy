//Problem 10. N Factorial
//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Text;

class NFactorial
{
    static string MultiplyAsArray(string multiplicand, int multiplier)
    {
        int[] array = new int[multiplicand.Length];
        for (int i = 0; i < multiplicand.Length; i++)
        {
            array[i] = multiplicand[i] - '0';
        }
        StringBuilder result = new StringBuilder();
        int reminder = 0;
        for (int i = array.Length-1; i >= 0; i--)
        {
            result.Insert(0, ((array[i] * multiplier) + reminder) % 10);
            reminder = ((array[i] * multiplier) + reminder) / 10;
        }
        if (reminder > 0)
        {
            result.Insert(0, reminder);
        }
        return result.ToString();
    }

    static void Main()
    {
        Console.WindowWidth = Console.WindowWidth * 2;
        string result = "1";
        for (int i = 1; i < 101; i++)
        {
            result = MultiplyAsArray(result,i);
            Console.WriteLine("{0}! = > {1}", i, result); 

        }
    }
}
