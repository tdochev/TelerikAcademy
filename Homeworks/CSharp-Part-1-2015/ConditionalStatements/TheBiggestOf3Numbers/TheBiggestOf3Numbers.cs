//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.
//Examples:
//a 	b 	    c 	    biggest
//5 	2 	    2 	    5
//-2 	-2 	    1 	    1
//-2 	4 	    3 	    4
//0 	-2.5 	5 	    5
//-0.1 	-0.5 	-1.1 	-0.1

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter first number");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number");
        double thirdNumber = double.Parse(Console.ReadLine());
        double biggestNumber = firstNumber;
        if (secondNumber > firstNumber)
        {
            biggestNumber = secondNumber;
        }
        if (biggestNumber < thirdNumber)
        {
            biggestNumber = thirdNumber;
        }
        Console.WriteLine("The biggest number is: " + biggestNumber);
    }
}

