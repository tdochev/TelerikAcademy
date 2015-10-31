//Problem 6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements.
//Examples:
//a 	b 	    c 	    d 	    e 	    biggest
//5 	2 	    2 	    4 	    1 	    5
//-2 	-22 	1 	    0 	    0 	    1
//-2 	4 	    3 	    2 	    0 	    4
//0 	-2.5 	0 	    5 	    5 	    5
//-3 	-0.5 	-1.1 	-2 	    -0.1 	-0.1

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter first number");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter forth number");
        double forthNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter fifth number");
        double fifthNumber = double.Parse(Console.ReadLine());
        double biggestNumber = firstNumber;
        if (secondNumber > firstNumber)
        {
            biggestNumber = secondNumber;
        }
        if (thirdNumber > biggestNumber)
        {
            biggestNumber = thirdNumber;
        }
        if (forthNumber > biggestNumber)
        {
            biggestNumber = forthNumber;
        }
        if (fifthNumber > biggestNumber)
        {
            biggestNumber = fifthNumber;
        }
        Console.WriteLine("The biggest number is: " + biggestNumber);
    }
}

