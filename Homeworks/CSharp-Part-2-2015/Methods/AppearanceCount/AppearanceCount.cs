//Problem 4. Appearance count
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
{
    static int CheckCountInArray(int number, int[] array)
    {
        int numberCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                numberCount++;
            }
        }
        return numberCount;
    }
    static void Main()
    {
        int number = 2;
        int[] numbersArray = { 1, 2, 2, 2, 3, 4, 2, 6 };
        Console.WriteLine("Number {0} appears {1} time/s in the given array",number, CheckCountInArray(number, numbersArray)); 
    }
}

