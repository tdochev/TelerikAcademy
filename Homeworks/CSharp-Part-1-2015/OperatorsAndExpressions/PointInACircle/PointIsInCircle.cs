//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
//Examples:
//x 	    y 	    inside
//0 	    1 	    true
//-2 	    0 	    true
//-1 	    2 	    false
//1.5 	    -1 	    true
//-1.5 	    -1.5 	false
//100 	    -30 	false
//0 	    0 	    true
//0.2 	    -0.8 	true
//0.9 	    -1.93 	false
//1 	    1.655 	true

using System;

class PointIsInCircle
{
    static void Main()
    {
        Console.WriteLine("Please enter point x coordinate in the circle:");
        double x = double.Parse(Console.ReadLine()); 
        Console.WriteLine("Please enter point y coordinate in the circle:");
        double y = double.Parse(Console.ReadLine());
        bool insideTheCircle = (Math.Pow(x-0, 2) + Math.Pow(y-0, 2)) <= Math.Pow(2, 2);
        Console.WriteLine("The point with coordinates ({0},{1}) is within circle K({{0,0}}, 2) - {2}", x, y, insideTheCircle);
    }
}

