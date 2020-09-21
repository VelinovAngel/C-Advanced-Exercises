using System;
using System.Linq;

namespace _1.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] currentRows = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRows[col];
                }
            }

            int diagonalSum = 0;
            int secondDiagonalSum = 0;
            int currentRow = 0;
            int currentCol = 0;

            while (true)
            {
                if (currentRow < 0 || currentRow > matrix.GetLength(0) - 1
                    || currentCol < 0 || currentCol > matrix.GetLength(1) - 1)
                {
                    break;
                }

                diagonalSum += matrix[currentRow, currentCol];
                currentRow++;
                currentCol++;
            }

            int currentSecondRow = 0;
            int currentSecondCol = matrix.GetLength(1) - 1;

            while (true)
            {
                if (currentSecondRow < 0 || currentSecondRow > matrix.GetLength(0) - 1
                    || currentSecondCol < 0 || currentSecondCol > matrix.GetLength(1))
                {
                    break;
                }
                secondDiagonalSum += matrix[currentSecondRow, currentSecondCol];
                currentSecondRow++;
                currentSecondCol--;

            }

            Console.WriteLine($"{Math.Abs(diagonalSum - secondDiagonalSum)}");
        }
    }
}
