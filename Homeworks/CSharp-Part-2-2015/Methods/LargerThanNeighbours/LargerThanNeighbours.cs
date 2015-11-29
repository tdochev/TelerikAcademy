//Problem 5. Larger than neighbours
//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

public class LargerThanNeighbours
{
    public static bool IsLargerThanNeighbours(int index, int[] array)
    {
        if (index == 0)
        {
            if (array[index] >= array[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        if (index == array.Length - 1)
        {
            if (array[index] >= array[index])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if (array[index] >= array[index + 1] && array[index] >= array[index - 1])
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    static void Main()
    {
        int index = 6;
        int[] numbersArray = { 1, 2, 5, 4, 5, 6, 7 };
        Console.WriteLine("The number at postion {0} is {1} than its two neighbors in the given array", index, IsLargerThanNeighbours(index,numbersArray) ? "larger" : "smaller");
    }
}

