using System;
using System.Linq;
using System.Text;

namespace _01.Structure3D
{
    public struct Point3D                      //task 1
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; } 
        public static readonly Point3D coordCenter = new Point3D(0, 0, 0);            //task 2

        //Constructor
        public Point3D(int coordX, int coordY, int coordZ)
            : this()
        {
            X = coordX;
            Y = coordY;
            Z = coordZ;
        }

        //Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("x coord: " + X);
            sb.AppendLine("y coord: " + Y);
            sb.AppendLine("z coord: " + Z);
            return sb.ToString();
        }
    }
}
