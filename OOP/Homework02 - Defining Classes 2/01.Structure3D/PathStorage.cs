using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace _01.Structure3D
{
    static class PathStorage              //task 4, second part
    {
        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\SavedPaths.txt"))
            {
                foreach (var point in path.PointList)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static List<Path> LoadPath()
        {
            Path pathToLoad = new Path();
            List<Path> pathsList = new List<Path>();

            using (StreamReader reader = new StreamReader(@"..\..\LoadPaths.txt"))
            {
                string newLine = reader.ReadLine();                

                while (newLine != string.Empty)
                {
                    Point3D newPoint = new Point3D();
                    newLine = reader.ReadLine();
                    
                    newPoint.X = int.Parse(newLine);
                    newLine = reader.ReadLine();
                    newPoint.Y = int.Parse(newLine);
                    newLine = reader.ReadLine();
                    newPoint.Z = int.Parse(newLine);

                    pathToLoad.AddPoint(newPoint);
                    newLine = reader.ReadLine();
                    
                    pathsList.Add(pathToLoad);
                    pathToLoad = new Path();
                    
                    
                }
            }

            return pathsList;
        }
    }
}
