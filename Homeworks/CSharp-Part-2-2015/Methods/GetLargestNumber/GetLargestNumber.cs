//Problem 2. Get largest number
//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
    static void Main()
    {
        Console.WriteLine("Please enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        int answer = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);
        Console.WriteLine("The largest number is:" + answer);
    }
}