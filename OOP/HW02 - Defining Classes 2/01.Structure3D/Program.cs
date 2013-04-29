using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _01.Structure3D                //tasks 1 to 4 are in this project
{    

    class Program
    {
        static void Main(string[] args)
        {
            var myPoint = new Point3D(1, 1, 6);
            Console.WriteLine("Point coordinates");            
            Console.WriteLine(myPoint);

            var secondPoint = new Point3D();
            Console.WriteLine(secondPoint);

            PointDistance.GetDistance(myPoint, secondPoint);

            //Path newPath = new Path();
            //newPath.AddPoint(myPoint);
            //newPath.AddPoint(secondPoint);

            //PathStorage.SavePath(newPath);

            List<Path> paths = PathStorage.LoadPath();
            foreach (var path in paths)
            {
                Console.WriteLine("Point data:");
                foreach (var point in path.PointList)
                {
                    Console.WriteLine(point);
                }
            }
            
        }
    }
}
