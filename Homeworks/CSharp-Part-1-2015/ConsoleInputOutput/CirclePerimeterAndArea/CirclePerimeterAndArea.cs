//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its
//perimeter and area formatted with 2 digits after the decimal point.
//Examples:
//r 	perimeter 	area
//2 	12.57 	    12.57
//3.5 	21.99 	    38.48

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter a radis in order to calculate perimeter and area of a circle: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("{0,-4} {1,-12} {2,-22}", "r", "perimeter", "area" );
        Console.WriteLine("{0,-4} {1,-12:0.00} {2,-22:0.00}", radius, perimeter, area);
    }
}
