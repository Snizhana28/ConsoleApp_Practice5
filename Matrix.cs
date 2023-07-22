using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice5
{
    public class Matrix
    {
        private int[,] matrix;
        private int rows;
        private int columns;

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns];
        }

        public void FillingRandom()
        {
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns;j++)
                {
                    matrix[i, j] = rand.Next(0, 10);
                }
            }
        }

        public void Output()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns;j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        // Overloaded operator +
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new Matrix(matrix1.rows, matrix1.columns);
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    result.matrix[i, j] = matrix1.matrix[i, j] + matrix2.matrix[i, j];
                }
            }
            return result;
        }
        // Overloaded operator - 
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new Matrix(matrix1.rows, matrix1.columns);
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    result.matrix[i, j] = matrix1.matrix[i, j] - matrix2.matrix[i, j];
                }
            }
            return result;
        }

        // Overloaded operator *
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new Matrix(matrix1.rows, matrix1.columns);
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    result.matrix[i, j] = matrix1.matrix[i, j] * matrix2.matrix[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix matrix , int num)
        {
            Matrix result = new Matrix(matrix.rows, matrix.columns);
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.columns; j++)
                {
                    result.matrix[i, j] = matrix.matrix[i, j] * num;
                }
            }
            return result;
        }

        // Overloaded operator ==
        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            bool result = false;
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    if (matrix1.matrix[i, j] == matrix2.matrix[i, j])
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        // Overloaded operator !=
        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            bool result = false;
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    if (matrix1.matrix[i, j] != matrix2.matrix[i, j])
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
