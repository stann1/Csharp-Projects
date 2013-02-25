using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    class Display
    {        
        private double? size;
        private int colorsCount;

        //Properties
        public double? Size
        {
            get { return this.size; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Screen size must be a positive number");
                }
                this.size = value;
            }
        }

        public int ColorsCount
        {
            get { return this.colorsCount; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of colors must be a positive number");
                }
                this.colorsCount = value;
            }
        }

        //Constructors
        public Display()
        {
        }

        public Display(double? size, int colorsCount)
        {
            this.Size = size;
            this.ColorsCount = colorsCount;
        }
    }
}
