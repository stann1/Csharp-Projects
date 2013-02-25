using System;
using System.Linq;

namespace _01.Structure3D
{
    static class PointDistance                   //task 3
    {
        
        public static void GetDistance(Point3D point1, Point3D point2)
        {
            double distance = 0;
            distance = Math.Sqrt((point1.X - point2.X)*(point1.X - point2.X) + (point1.Y - point2.Y)*(point1.Y - point2.Y) + (point1.Z - point2.Z)*(point1.Z - point2.Z));
            Console.WriteLine("The distance between the two points: " + distance);            
        }
    }
}
