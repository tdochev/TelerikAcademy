//Problem 2. Float or Double?
//Which of the following values can be assigned to a variable of
//type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.
using System;

    class FloatOrDouble
    {
        static void Main()
        {
            double firstVariable = 34.567839023;
            Console.WriteLine(firstVariable);
            float secondVariable = 12.345f;
            Console.WriteLine(secondVariable);
            double thirdVariable = 8923.1234857;
            Console.WriteLine(thirdVariable);
            float forthVariable = 3456.091f;
            Console.WriteLine(forthVariable);
        }
    }

