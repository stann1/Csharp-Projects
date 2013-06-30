using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PointInTriangle
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) : this()
        {
            this.X = x;
            this.Y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point searched = new Point(1, 1);

            Point triangleEdge1 = new Point(0, 0);
            Point triangleEdge2 = new Point(2, 2);
            Point triangleEdge3 = new Point(2, 0);

            int A = triangleEdge1.X - triangleEdge3.X;
            int B = triangleEdge1.Y - triangleEdge3.Y;
            int C = triangleEdge2.X - triangleEdge3.X;
            int D = triangleEdge2.Y - triangleEdge3.Y;

            double alpha = D * (searched.X - triangleEdge3.X) - C * (searched.Y - triangleEdge3.Y);
            alpha = alpha / (A * D - B * C);

            double beta = -B * (searched.X - triangleEdge3.X) + A * (searched.Y - triangleEdge3.Y);
            beta = beta / (A * D - B * C);

            double gamma = 1 - alpha - beta;

            if (alpha >= 0 && beta >= 0 && gamma >= 0)
            {
                Console.WriteLine("Point ({0},{1}) lies in the circle", searched.X, searched.Y);
            }
            else
            {
                Console.WriteLine("Point ({0},{1}) does not lie in the circle", searched.X, searched.Y);
            }

        }
    }
}
