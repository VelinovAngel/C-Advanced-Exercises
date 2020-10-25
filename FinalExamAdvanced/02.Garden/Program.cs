using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = size[0];
            int m = size[1];

            int[,] matrix = new int[n, m];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }

            Dictionary<int, int> currPos = new Dictionary<int, int>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] position = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currRow = position[0];
                int currCol = position[1];

                if (IsOutside(n, m, currRow, currCol))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                else
                {
                    currPos.Add(currRow, currCol);
                    matrix[currRow, currCol] = 1;
                }


            }

            foreach (var (key, value) in currPos)
            {
                int row = key;
                int col = value;

                for (int i = row + 1; i < matrix.GetLength(0); i++)
                {
                    matrix[i, col] += 1;
                }

                for (int i = row - 1; i >= 0; i--)
                {
                    matrix[i, col] += 1;
                }

                for (int i = col + 1; i < matrix.GetLength(1); i++)
                {
                    matrix[row, i] += 1;
                }

                for (int i = col - 1; i >= 0; i--)
                {
                    matrix[row, i] += 1;
                }
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        private static bool IsOutside(int n, int m, int row, int col)
        {
            return row >= n ||
                    row < 0 ||
                    col >= m ||
                    col < 0;
        }
    }
}