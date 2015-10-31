//Problem 4. Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
//Examples:
//a 	b 	    c 	    result
//5 	2 	    2 	    +
//-2 	-2 	    1 	    +
//-2 	4 	    3 	    -
//0 	-2.5 	4 	    0
//-1 	-0.5 	-5.1 	-

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please enter first real number");
        int firstSign = Math.Sign(double.Parse(Console.ReadLine()));
        Console.WriteLine("Please enter second real number");
        int secondSign = Math.Sign(double.Parse(Console.ReadLine()));
        Console.WriteLine("Please enter third real number");
        int thirdSign = Math.Sign(double.Parse(Console.ReadLine()));
        //if (firstSign * secondSign * thirdSign == 0)
        //{
        //    Console.WriteLine("Result:" + 0);
        //}
        //if (firstSign * secondSign * thirdSign < 0)
        //{
        //    Console.WriteLine("Result:" + "-");
        //}
        //if (firstSign * secondSign * thirdSign > 0)
        //{
        //    Console.WriteLine("Result:" + "+");
        //}
        if (firstSign == 0 || secondSign == 0 || thirdSign == 0  )
        {
            Console.WriteLine("Result:" + 0);
        }
        else if ((firstSign > 0 && secondSign > 0 && thirdSign > 0) ||
            (firstSign < 0 && secondSign < 0 && thirdSign > 0) ||
            (firstSign < 0 && secondSign > 0 && thirdSign < 0) ||
            (firstSign > 0 && secondSign < 0 && thirdSign < 0))
        {
            Console.WriteLine("Result:" + "+");
        }
        else
        {
            Console.WriteLine("Result:" + "-");
        }
    }
}

