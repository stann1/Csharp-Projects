using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> figures = new List<Shape>();
            figures.Add(new Triangle(6, 8));
            figures.Add(new Triangle(16, 6));
            figures.Add(new Rectangle(8, 8));
            figures.Add(new Circle(12));
            figures.Add(new Circle(8));

            foreach (var figure in figures)
            {
                Console.WriteLine("The {0} area is: {1}", figure.GetType().Name, figure.CalculateSurface());
            }

        }
    }
}
