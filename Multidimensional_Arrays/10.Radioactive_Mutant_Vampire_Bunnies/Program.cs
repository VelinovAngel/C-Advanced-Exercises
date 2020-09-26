using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            int playerRow = -1;
            int playerCol = -1;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colValues = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colValues[col];

                    if (colValues[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();
            bool isWon = false;
            foreach (char direction in directions)
            {

                int currentPlayerRow = playerRow;
                int currentPlayerCol = playerCol;
                switch (direction)
                {

                    case 'U':
                        currentPlayerRow--;
                        break;
                    case 'D':
                        currentPlayerRow++;
                        break;
                    case 'L':
                        currentPlayerCol--;
                        break;
                    case 'R':
                        currentPlayerCol++;
                        break;
                }

                isWon = IsWon(matrix, currentPlayerRow, currentPlayerCol);

                if (isWon)
                {
                    matrix[playerRow, playerCol] = '.';
                }
                else
                {
                    if (matrix[currentPlayerRow, currentPlayerCol] == 'B')
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerRow = currentPlayerRow;
                        playerCol = currentPlayerCol;
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = '.';
                        matrix[currentPlayerRow, currentPlayerCol] = 'P';
                        playerRow = currentPlayerRow;
                        playerCol = currentPlayerCol;
                    }
                }

                List<int> bunnies = new List<int>();

                for (int row = 0; row < rows; row++)
                {

                    for (int col = 0; col < cols; col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            bunnies.Add(row);
                            bunnies.Add(col);
                        }
                    }
                }

                for (int i = 0; i < bunnies.Count; i += 2)
                {
                    int bunnyRow = bunnies[i];
                    int bunnyCol = bunnies[i + 1];

                    SpreadBunny(matrix, bunnyRow, bunnyCol);
                }

                //Won or dead

                if (isWon || matrix[playerRow, playerCol] == 'B')
                {
                    break;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

            if (isWon)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }

        private static void SpreadBunny(char[,] matrix, int bunnyRow, int bunnyCol)
        {
            if (bunnyRow - 1 >= 0)
            {
                matrix[bunnyRow - 1, bunnyCol] = 'B';
            }

            if (bunnyRow + 1 < matrix.GetLength(0))
            {
                matrix[bunnyRow + 1, bunnyCol] = 'B';
            }

            if (bunnyCol - 1 >= 0)
            {
                matrix[bunnyRow, bunnyCol - 1] = 'B';
            }

            if (bunnyCol + 1 < matrix.GetLength(1))
            {
                matrix[bunnyRow, bunnyCol + 1] = 'B';
            }
        }

        private static bool IsWon(char[,] matrix, int currentPlayerRow, int currentPlayerCol)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            return currentPlayerRow < 0 || currentPlayerRow >= n || currentPlayerCol < 0 || currentPlayerCol >= m;
        }
    }
}
