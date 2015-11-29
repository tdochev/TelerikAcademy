//Problem 13. Solve tasks
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;

class SolveTasks
{
    const string firstTask = "1. Reverses the digits of a number";
    const string secondTask = "2. Calculates the average of a sequence of integers";
    const string thirdTask = "3. Solve a linear equation a * x + b = 0";
    static decimal ReverseDecimal(decimal decimalToReverse)
    {
        string answer = "";
        for (int i = decimalToReverse.ToString().Length - 1; i >= 0; i--)
        {
            answer += decimalToReverse.ToString()[i];
        }
        return decimal.Parse(answer);
    }
    static decimal Average(string input)
    {
        string[] numbersAsString = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        if (numbersAsString.Length == 0)
        {
            return 0;
        }
        int[] numbers = new int[numbersAsString.Length];
        decimal sum = 0;
        decimal result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsString[i]);
            sum += numbers[i];
        }
        result = sum / numbers.Length;
        return result;
    }
    static double SolveLinearEquation(double a, double b)
    { 
    return -b/a;
    }
    static void Main()
    {
        ConsoleKeyInfo cki;
        do
        {
            Console.Clear();
            Menu();
            cki = Console.ReadKey(true);
            switch (cki.KeyChar.ToString())
            {
                case "1":
                    bool notInMenu1 = true;
                    while (notInMenu1)
                    {
                        Console.Clear();
                        Console.WriteLine(firstTask);
                        Console.WriteLine("Please enter a number to reverse it:");
                        decimal numberToReverse = decimal.Parse(Console.ReadLine());
                        while (numberToReverse < 0)
                        {
                            Console.WriteLine("The number should not be negative!");
                            Console.WriteLine("Please eneter another positive number:");
                            numberToReverse = decimal.Parse(Console.ReadLine());
                        }
                        Console.WriteLine(ReverseDecimal(numberToReverse));
                        Console.WriteLine("Press ecape to exit to menu or press enter to reverse another decimal:");
                        ConsoleKeyInfo cki1 = new ConsoleKeyInfo();
                        cki1 = Console.ReadKey(true);
                        if (cki1.Key== ConsoleKey.Escape)
                        {
                            notInMenu1 = false;
                        }
                    }
                    break;
                case "2":
                    bool notInMenu2 = true;
                    while (notInMenu2)
                    {
                        Console.Clear();
                        Console.WriteLine(secondTask);
                        Console.WriteLine("Please enter a sequence of integers separated by comma:");
                        string sequence = Console.ReadLine();
                        while (Average(sequence)==0)
                        {
                            Console.WriteLine("The sequnece is empty!");
                            Console.WriteLine("Please eneter another sequnece:");
                            sequence = Console.ReadLine();
                        }
                        Console.WriteLine("The average of you sequence is:" + Average(sequence));
                        Console.WriteLine("Press ecape to exit to menu or press enter to calculate the average of another sequence:");
                        ConsoleKeyInfo cki1 = new ConsoleKeyInfo();
                        cki1 = Console.ReadKey(true);
                        if (cki1.Key == ConsoleKey.Escape)
                        {
                            notInMenu2 = false;
                        }
                    }
                    break;
                case "3":
                    bool notInMenu3 = true;
                    while (notInMenu3)
                    {
                        Console.Clear();
                        Console.WriteLine(thirdTask);
                        Console.WriteLine("Please enter a:");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter b:");
                        double b = double.Parse(Console.ReadLine());
                        while (a == 0)
                        {
                            Console.WriteLine("a should not be zero:");
                            Console.WriteLine("Please eneter another value for a:");
                            a = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("The value of x in your linear euqation => {0} * x + {1} = 0 is: x={2}",a,b,SolveLinearEquation(a,b));
                        Console.WriteLine("Press ecape to exit to menu or press enter to calculate another linear equation:");
                        ConsoleKeyInfo cki1 = new ConsoleKeyInfo();
                        cki1 = Console.ReadKey(true);
                        if (cki1.Key == ConsoleKey.Escape)
                        {
                            notInMenu3 = false;
                        }
                    }
                    break;
            }
        } while (cki.Key != ConsoleKey.Escape);
    }
    static void Menu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine(new string('-', Console.WindowWidth - 1));
        Console.WriteLine(firstTask);
        Console.WriteLine(secondTask);
        Console.WriteLine(thirdTask);
        Console.WriteLine("Press Esc to exit...");
        Console.WriteLine(new string('-', Console.WindowWidth - 1));
        Console.WriteLine("The system is awaiting your input:");
    }
}

