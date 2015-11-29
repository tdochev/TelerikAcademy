//Problem 15.* Number calculations
//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Linq;

class IntegerCalculations
{
    static T Minimum<T>(T[] input)
    {
        dynamic min = input[0];
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] < min)
            {
                min = input[i];
            }
        }
        return min;

    }
    static T Maximum<T>(T[] input)
    {
        dynamic max = input[0];
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] > max)
            {
                max = input[i];
            }
        }
        return max;
    }
    static T Average<T>(T[] input)
    {

        dynamic sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum += input[i];
        }
        sum /= input.Length;
        return sum;
    }
    static T Sum<T>(T[] input)
    {
        dynamic sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum += input[i];
        }
        return sum;
    }
    static T Product<T>(T[] input)
    {
        dynamic product = 1;
        for (int i = 0; i < input.Length; i++)
        {
            product *= input[i];
        }
        return product;
    }
    static void Main()
    {
        decimal[] decimalArray = { 2.53m, 5.56m, 56.0m };
        Console.WriteLine("Calculations for decimal array with generic methods:");
        Console.WriteLine("Decimal array: " + string.Join(", ", decimalArray));
        Console.WriteLine("Min: {0}\nMax: {1}\nAverage: {2}\nSum: {3}\nProduct: {4}", Minimum(decimalArray), Maximum(decimalArray), Average(decimalArray), Sum(decimalArray), Product(decimalArray));
        Console.WriteLine(new string('-', Console.WindowWidth - 1));
        float[] floatArray = { 2.989f, 13.24f, 56.93f };
        Console.WriteLine("Calculations for float array with generic methods:");
        Console.WriteLine("Decimal array: " + string.Join(", ", floatArray));
        Console.WriteLine("Min: {0}\nMax: {1}\nAverage: {2}\nSum: {3}\nProduct: {4}", Minimum(floatArray), Maximum(floatArray), Average(floatArray), Sum(floatArray), Product(floatArray));
        Console.WriteLine(new string('-', Console.WindowWidth - 1));
        int[] intArray = { 2, 2, 2, 2 };
        Console.WriteLine("Calculations for int array with generic methods:");
        Console.WriteLine("Decimal array: " + string.Join(", ", intArray));
        Console.WriteLine("Min: {0}\nMax: {1}\nAverage: {2}\nSum: {3}\nProduct: {4}", Minimum(intArray), Maximum(intArray), Average(intArray), Sum(intArray), Product(intArray));
        Console.WriteLine(new string('-', Console.WindowWidth - 1));
    }

}
