//Problem 8. Number as array
//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Text;

class NumberAsArray
{
    static string AddNumbersAsArray(string firstNumber, string secondNumber)
    {
        if (firstNumber.Length > secondNumber.Length)
        {
            secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
        }
        if (secondNumber.Length > firstNumber.Length)
        {
            firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
        }
        int[] firstArray = CreateArrayFromString(firstNumber);
        int[] secondArray = CreateArrayFromString(secondNumber);
        StringBuilder result = new StringBuilder();
        int reminder = 0;
        for (int i = 0; i < firstArray.Length; i++)
        {
            result.Insert(0,(firstArray[i] + secondArray[i] + reminder) % 10);
            reminder = (firstArray[i] + secondArray[i] + reminder) / 10;
        }
        if (reminder>0)
        {
            result.Insert(0,reminder);
        }
        return result.ToString();
    }
    static int[] CreateArrayFromString(string numer)
    {
        int[] array = new int[numer.Length];
        for (int i = 0; i < numer.Length; i++)
        {
            array[i] = numer[numer.Length - i - 1] - '0';
        }
        return array;
    }

    static void Main()
    {
        Console.WriteLine("Please enter positive integer number with up to 10 000 digits");
        string firstNumber = Console.ReadLine();
        Console.WriteLine("Please enter another positive integer number with up to 10 000 digits");
        string secondNumber = Console.ReadLine();
        Console.WriteLine("The sum of the two number you entered is: {0}",AddNumbersAsArray(firstNumber, secondNumber));
    }
}
