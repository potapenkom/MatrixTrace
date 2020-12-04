using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixTrace
{
    public class Matrix
    {
        private int[,] _matrix;

        public Matrix(int[,] matrix)
        {
            _matrix = matrix;
        }

        public void GenerateMatrix()
        {
            int rows = _matrix.GetUpperBound(0) + 1;
            int columns = _matrix.Length / rows;
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    _matrix[i, j] = rand.Next(1, 100);
                }
            }
        }

        public int FindTraceOfMatrix()
        {
            Random rand = new Random();
            int rows = _matrix.GetUpperBound(0) + 1;
            int columns = _matrix.Length / rows;
            int sum = 0;
            Console.Write("\nThe matrix is : \n");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < columns; j++)
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0}\t", _matrix[i, j]);
                        Console.ResetColor();
                        sum += _matrix[i, j];
                    }
                    else
                    {
                        Console.Write("{0}\t", _matrix[i, j]);
                    }
            }
            Console.Write("\n\n");
            return sum;
        }

    }
}
