//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intValue = null;
        double? doubleValue = null;
        Console.WriteLine(intValue);
        Console.WriteLine(doubleValue);
        intValue += 100;
        doubleValue += 100.100;
        Console.WriteLine(intValue);
        Console.WriteLine(doubleValue);

    }
}

