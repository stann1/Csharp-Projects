using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    public abstract class Shape
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        //Constructor
        protected Shape(int width, int height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("The dimensions must be possitive numbers!");
            }
            this.Width = width;
            this.Height = height;
        }

        //Methods
        public abstract double CalculateSurface();
       
    }
}
