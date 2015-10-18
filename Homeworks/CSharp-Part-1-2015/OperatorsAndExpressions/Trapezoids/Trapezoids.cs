﻿//Problem 9. Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h.
//Examples:
//a 	    b 	    h 	    area
//5 	    7 	    12 	    72
//2 	    1 	    33 	    49.5
//8.5 	    4.3 	2.7 	17.28
//100 	    200 	300 	45000
//0.222 	0.333 	0.555 	0.1540125

using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Please enter side a of the trapezoid:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter side b of the trapezoid:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter height h of the trapezoid:");
        double h = double.Parse(Console.ReadLine());
        double area = (a + b) / 2 * h;
        Console.WriteLine("The area of the given trapezoid is: {0}", area);
    }
}
