using System;
using System.Linq;

namespace _01.ProperVariableNaming
{
    class ProperVariableNaming
    {
        static void Main(string[] args)
        {
            Size figureSize = new Size(8, 6);
            Size rotatedFigureSize = Size.GetRotatedSize(figureSize, 26);
            Console.WriteLine("Rotated figure width: {0}, height: {1}", rotatedFigureSize.Width, rotatedFigureSize.Height);
        }

    }

    

}
