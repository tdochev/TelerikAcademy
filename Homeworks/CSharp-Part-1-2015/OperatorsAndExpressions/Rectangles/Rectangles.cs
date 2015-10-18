//Problem 4. Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height.
//Examples:
//width 	height 	perimeter 	area
//3 	    4 	    14 	        12
//2.5 	    3 	    11 	        7.5
//5 	    5 	    20 	        25

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Please enter the width of the rectangle:");
        decimal width = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the height of the rectangle:");
        decimal height = decimal.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the rectangle is {0} and it's area is {1}", (2 * width) + (2 * height), height * width);
    }
}

