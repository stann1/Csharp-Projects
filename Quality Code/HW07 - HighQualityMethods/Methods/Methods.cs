using System;

namespace Methods
{
    enum Format
    {
        Float,
        Percentage,
        RoundTrip
    }

    class Methods
    {
        static double CalculateTriangleArea(double sideOne, double sideTwo, double sideThree)
        {
            if (sideOne <= 0 || sideTwo <= 0 || sideThree <= 0)
            {
                throw new ArgumentException("The sides of the triangle must be positive numbers");
            }
            double halfPerimeter = (sideOne + sideTwo + sideThree) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideOne) * (halfPerimeter - sideTwo) * (halfPerimeter - sideThree));
            return area;
        }

        static string ConvertDigitToText(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Invalid number!";
            }
           
        }
               
        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("The elements to be compared, should be at least 1");
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        static void PrintNumberInFormat(double number, Format format)
        {
            if (format == Format.Float)
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == Format.Percentage)
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == Format.RoundTrip)
            {
                Console.WriteLine("{0,8}", number);
            }
        }
        
        static double CalculateDistance(double pointOneCoordX, double pointOneCoordY, double pointTwoCoordX, double pointTwoCoordY)
        {           
            double distance = Math.Sqrt((pointTwoCoordX - pointOneCoordX) * (pointTwoCoordX - pointOneCoordX) + (pointTwoCoordY - pointOneCoordY) * (pointTwoCoordY - pointOneCoordY));
            return distance;
        }

        static string ShowIfPointsLieOnOneLine(double pointOneCoordX, double pointOneCoordY, double pointTwoCoordX, double pointTwoCoordY)
        {
            bool horizontalLine = false;
            bool verticalLine = false;

            if (pointOneCoordX == pointTwoCoordX)
            {
                verticalLine = true;
            }
            if (pointOneCoordY == pointTwoCoordY)
            {
                horizontalLine = true;
            }

            if (horizontalLine && verticalLine)
            {
                return "The two points are the same";
            }
            else if (horizontalLine && !verticalLine)
            {
                return "The two points lie on the same horizontal line";
            }
            else if (!horizontalLine && verticalLine)
            {
                return "The two points lie on the same vertical line";
            }
            else
            {
                return "The points are not on the same line";
            }

        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(ConvertDigitToText(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            PrintNumberInFormat(1.3, Format.Float);
            PrintNumberInFormat(0.75, Format.Percentage);
            PrintNumberInFormat(2.30, Format.RoundTrip);
           
            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine(ShowIfPointsLieOnOneLine(3, -1, 3, 2.5));            

            Student studentOne = new Student() { FirstName = "Peter", LastName = "Ivanov", BirthDate = "17.03.1992" };
            studentOne.AdditionalInformation = "From Sofia";

            Student studentTwo = new Student() { FirstName = "Stella", LastName = "Markova", BirthDate = "03.11.1993" };
            studentTwo.AdditionalInformation = "From Vidin, gamer, high results";

            Console.WriteLine("{0} older than {1} -> {2}",
                studentOne.FirstName, studentTwo.FirstName, studentOne.IsOlderThan(studentTwo));
        }
    }
}
