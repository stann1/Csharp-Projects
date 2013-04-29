using System;
using System.Linq;

namespace _01.ProperVariableNaming
{
    public class Size
    {
        private double width;
        private double height;        

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The dimension must be a positive value!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The dimension must be a positive value!");
                }
                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size size, double angleOfTheFigureToRotate)
        {
            double widthCosinus = Math.Abs(Math.Cos(angleOfTheFigureToRotate));
            double widthSinus = Math.Abs(Math.Sin(angleOfTheFigureToRotate));
            double rotatedWidth = widthCosinus * size.Width + widthSinus * size.Height;

            double heightSinus = Math.Abs(Math.Sin(angleOfTheFigureToRotate));
            double heightCosinus = Math.Abs(Math.Cos(angleOfTheFigureToRotate));
            double rotatedHeight = heightSinus * size.Width + heightCosinus * size.Height;

            return new Size(rotatedWidth, rotatedHeight);
        }
    } 
}

