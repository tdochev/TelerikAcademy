//Problem 4. Triangle surface
//Write methods that calculate the surface of a triangle by given:
//    Side and an altitude to it;
//    Three sides;
//    Two sides and an angle between them;
//Use System.Math.
//Example:
//input 	output
//* a = 23.2, h = 5 	58
//* a = 11, b =12, c = 13 	61.48
//* a = 10, b = 7, C = 25° 	14.79

using System;

class TriangleSurface
{

    static double SurfaceSideAltitude(double side, double altitude)
    {
        return (side * altitude) / 2;
    }

    private static double SurfaceThreeSides(double firstSide, double secondSide, double thirdSide)
    {
        double semiPerimeter = (firstSide + secondSide +thirdSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));
    }

    private static double SurfaceTwoSidesAndAngle(double firstSide, double secondSide, double angle)
    {
        return firstSide * secondSide * (Math.Sin(Math.PI * angle / 180.0)) / 2;
    }

    static void Main()
    {
        Console.WriteLine("Please enter side of a triangle:");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the altitude to it:");
        double altitude = double.Parse(Console.ReadLine());
        Console.WriteLine("The surface of the given triangle is: {0}", SurfaceSideAltitude(side,altitude));
        Console.WriteLine("Please first side of a triangle:");
        double firstSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Please second side of a triangle:");
        double secondSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Please third side of a triangle:");
        double thirdSide = double.Parse(Console.ReadLine());
        Console.WriteLine("The surface of the given triangle is: {0:f2}", SurfaceThreeSides(firstSide,secondSide,thirdSide));
        Console.WriteLine("Please first side of a triangle:");
        double firstSides = double.Parse(Console.ReadLine());
        Console.WriteLine("Please second side of a triangle:");
        double secondSides = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the angle between first side and second side:");
        double angle = double.Parse(Console.ReadLine());
        Console.WriteLine("The surface of the given triangle is: {0:f2}", SurfaceTwoSidesAndAngle(firstSides, secondSides, angle));
    }
}

