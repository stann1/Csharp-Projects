using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Circle : Shape
    {
        public Circle(int diameter)
            : base(diameter, diameter)
        {
        }

        public override double CalculateSurface()
        {
            return Math.Pow((this.Width/2.0), 2) * Math.PI;
        }
    }
}
