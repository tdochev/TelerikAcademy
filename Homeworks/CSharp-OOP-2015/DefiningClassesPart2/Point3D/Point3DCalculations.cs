////Problem 3. Static class
////Write a static class with a static method to calculate the distance between two points in the 3D space.
namespace Point3D
{
    using System;

    public static class Point3DCalculations
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double xdistance = Math.Pow(secondPoint.X - firstPoint.X, 2);
            double ydistance = Math.Pow(secondPoint.Y - firstPoint.Y, 2);
            double zdistance = Math.Pow(secondPoint.Z - firstPoint.Z, 2);
            return Math.Sqrt(xdistance + ydistance + zdistance);
        }
    }
}
