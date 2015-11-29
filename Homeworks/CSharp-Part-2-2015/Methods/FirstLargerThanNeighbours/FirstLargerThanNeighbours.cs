//Problem 6. First larger than neighbours
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstLargerThanNeighbours
{
    static int FirstLarger(int[] array) 
    {
        int result = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (LargerThanNeighbours.IsLargerThanNeighbours(i,array))
            {
                result = i;
                break;
            }
        }
        return result;
    }
    static void Main()
    {
        int[] numbersArray = { 0, 1, 2, 8, 4, 5, 6 };
        Console.WriteLine("The index of the first element in array that is larger than its neighbours is {0}", FirstLarger(numbersArray));
    }
}

