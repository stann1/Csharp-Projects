using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Triangle : Shape
    {
        public Triangle(int width, int height)
            : base(width, height)
        {
        }

        //Implement abstract method
        public override double CalculateSurface()
        {
            return (this.Width * this.Height)/2.0;
        }
    }
}
