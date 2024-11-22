using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Matrixok
    {
        private double[,] matrix;

        public Matrixok(int m, int n)
        {
            matrix = new double[m, n];
        }

        public Matrixok(int n)
        {
            matrix = new double[n, n];
        }

        public Matrixok()
        {
            matrix = new double[3, 3];
        }

        public static Matrixok Sum(Matrixok A, Matrixok B)
        {
            if (A.Rows != B.Rows || A.Columns != B.Columns)
            {
                throw new ArgumentException("A két mátrix nem ugyanakkora méretű!");
            }

            Matrixok result = new Matrixok(A.Rows, A.Columns);

            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Columns; j++)
                {
                    result.matrix[i, j] = A.matrix[i, j] + B.matrix[i, j];
                }
            }

            return result;
        }


        public void Fill(double value)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = value;
                }
            }
        }

        public int Rows
        {
            get { return matrix.GetLength(0); }
        }

        public int Columns
        {
            get { return matrix.GetLength(1); }
        }

        public void Print()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
