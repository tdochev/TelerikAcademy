//Problem 17.* Calculate GCD
//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).
//Examples:
//a 	b 	GCD(a, b)
//3 	2 	1
//60 	40 	20
//5 	-15 	5

using System;

class GCD
{
    static void Main()
    {
        Console.WriteLine("Please enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter b:");
        int b = int.Parse(Console.ReadLine());
        while (b > 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        Console.WriteLine("GCD = " + a);
    }
}