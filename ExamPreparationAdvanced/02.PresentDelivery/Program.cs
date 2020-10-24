using System;

namespace _02.PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPresents = int.Parse(Console.ReadLine());

            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            ReadMatrix(matrix);
            PrintMatrix(matrix);
        }

        static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < line.Length - 1; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
