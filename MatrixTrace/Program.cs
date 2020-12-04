using System;

namespace MatrixTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            int columns;
            Console.Write("enter the number of rows: ");
            while (!int.TryParse(Console.ReadLine(), out rows) || rows < 2)
            {
                Console.WriteLine("Wrong number");
            }
            Console.Write("enter the number of coluns: ");
            while (!int.TryParse(Console.ReadLine(), out columns) || columns < 2)
            {
                Console.WriteLine("Wrong number");
            }
            int[,] arr = new int[rows, columns];
            Matrix matrix = new Matrix(arr);
            matrix.GenerateMatrix();
            Console.WriteLine($"Matrix trace is {matrix.FindTraceOfMatrix()}");
        }
    }
}
