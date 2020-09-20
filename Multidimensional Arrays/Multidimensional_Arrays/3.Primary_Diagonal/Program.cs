using System;
using System.Linq;

namespace _3.Primary_Diagonal
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
            int currentRow = 0;
            int currentCol = 0;

            while (true)
            {
                if (currentRow < 0 || currentRow > matrix.GetLength(0)-1
                    || currentCol < 0 || currentCol > matrix.GetLength(1) -1)
                {
                    break;
                }

                diagonalSum += matrix[currentRow, currentCol];
                currentRow++;
                currentCol++;
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
