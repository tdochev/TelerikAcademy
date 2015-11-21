//Problem 2. Compare arrays
// Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        bool arraysAreTheSame = true;
        Console.WriteLine("Please enter n for the lenght of the first array you would like to compare: ");
        int n1 = int.Parse(Console.ReadLine());
        int[] firstarray = new int[n1];
        for (int i = 0; i < n1; i++)
        {
            firstarray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please enter n for the lenght of the first array you would like to compare: ");
        int n2 = int.Parse(Console.ReadLine());
        int[] secondarray = new int[n2];
        if (firstarray.Length != secondarray.Length)
        {
            Console.WriteLine("The arrays you are trying to compare have different lenght!");
        }
        else
        {
            for (int i = 0; i < n2; i++)
            {
                secondarray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n1; i++)
            {
                if (firstarray[i] != secondarray[i])
                {
                    arraysAreTheSame = false;
                }

            }
            if (arraysAreTheSame == true)
            {
                Console.WriteLine("Your arrays are exactly the same.");
            }
            else
            {
                Console.WriteLine("Your arrays are not the same.");
            }
        }
    }
}

