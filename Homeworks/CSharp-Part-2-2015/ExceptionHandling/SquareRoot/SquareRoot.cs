//Problem 1. Square root
//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;


class SquareRoot
{
    static void SQRT(int number)
    {
        double result = Math.Sqrt(number);
        Console.WriteLine("The suqare root of {0} is {1}", number, result);
    }
    static void Main()
    {
        Console.WriteLine("Please enter a number to  get it's square root: ");
        try
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 0)
            {
                throw new NotFiniteNumberException();
            }
            SQRT(input);
        }
        catch (NotFiniteNumberException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }

}

