using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericMatrix                       //includes task 8 - 10
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<double> firstMatrix = new Matrix<double>(2, 2);
            firstMatrix[0, 0] = 1;
            firstMatrix[0, 1] = 1;
            firstMatrix[1, 0] = 3;
            firstMatrix[1, 1] = 3;
            Matrix<double> secondMatrix = new Matrix<double>(2, 2);
            secondMatrix[0, 0] = 2;
            secondMatrix[0, 1] = 2;
            secondMatrix[1, 0] = 2;
            secondMatrix[1, 1] = 2;

            Matrix<double> result = firstMatrix * secondMatrix;
            Console.WriteLine(result[1,0]);

            Matrix<string> newMatrix = new Matrix<string>(3, 3);
            newMatrix[0, 1] = "mofo";

            if (newMatrix)
            {                
                Console.WriteLine("Not an empty matrix");
            }
            else
            {
                Console.WriteLine("Empty matrix");
            }

        }
    }
}
