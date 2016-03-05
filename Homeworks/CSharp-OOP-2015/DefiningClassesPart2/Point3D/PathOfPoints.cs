////Problem 4. Path
////Create a class Path to hold a sequence of points in the 3D space.

namespace Point3D
{
    using System.Collections.Generic;

    public class PathOfPoints
    {
        public PathOfPoints()
        {
            this.PointsPath = new List<Point3D>();
        }

        public List<Point3D> PointsPath { get; private set; }

        public void AddPoint(Point3D somePoint)
        {
            this.PointsPath.Add(somePoint);
        }
    }
}
