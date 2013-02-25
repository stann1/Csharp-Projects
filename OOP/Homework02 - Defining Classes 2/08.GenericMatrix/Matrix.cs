using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericMatrix
{
    public class Matrix<T>             //task 8
    {
        private T[,] matrix;
        private int rows;
        private int columns;

        //Properties
        public int RowCount
        {
            get { return this.rows; }
        }

        public int ColumnCount
        {
            get { return this.columns; }
        }

        //Constructor
        public Matrix(int totalRows, int totalColumns)
        {
            this.rows = totalRows;
            this.columns = totalColumns;
            this.matrix = new T[rows, columns];
        }

        //Indexer
        public T this[int row, int col]            //task 9
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        //Methods
        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.rows, matrix1.columns);

            if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
            {
                throw new ArgumentException("Matrix addition cannot be performed on matrices of different size");
            }
            else
            {
                for (int i = 0; i < matrix1.rows; i++)
                {
                    for (int j = 0; j < matrix1.columns; j++)
                    {
                        resultMatrix[i, j] = (dynamic)matrix1[i, j] + (dynamic)matrix2[i, j];
                    }
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.rows, matrix1.columns);

            if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
            {
                throw new ArgumentException("Matrix substraction cannot be performed on matrices of different size");
            }
            else
            {
                for (int i = 0; i < matrix1.rows; i++)
                {
                    for (int j = 0; j < matrix1.columns; j++)
                    {
                        resultMatrix[i, j] = (dynamic)matrix1[i, j] - (dynamic)matrix2[i, j];
                    }
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.rows, matrix1.columns);

            if (matrix1.columns != matrix2.rows)
            {
                throw new ArgumentException("Matrix multiplication can be performed only if m1(columns) = m2(rows)");
            }
            else
            {
                for (int i = 0; i < matrix1.rows; i++)
                {                    
                    for (int k = 0; k < matrix2.columns; k++)
                    {                        
                        for (int j = 0; j < matrix2.rows; j++)
                        {
                            resultMatrix[i, k] += (dynamic)matrix1[i, j] * (dynamic)matrix2[j, k];
                        }
                    }
                    
                }
            }

            return resultMatrix;
        }

        public static bool TrueFalse(Matrix<T> matrix, bool condition)       //Joint method for true anf false
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.columns; j++)
                {
                    T temp = default(T);
                    if ((dynamic)matrix[i, j] != temp)
                    {
                        return condition;
                    }
                }
            }
            return !condition;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return TrueFalse(matrix, true);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return TrueFalse(matrix, false);
        }
    }
}
