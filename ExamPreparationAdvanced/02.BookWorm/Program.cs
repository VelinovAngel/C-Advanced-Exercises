using System;
using System.Linq;
using System.Text;

namespace _02.BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder initialString = new StringBuilder(Console.ReadLine());

            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }


            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                matrix[playerCol, playerRow] = '-';
                switch (input)
                {
                    case "up":
                        playerRow--;
                        break;
                    case "down":
                        playerRow++;
                        break;
                    case "left":
                        playerCol--;
                        break;
                    case "right":
                        playerCol++;
                        break;
                }

                if (playerCol > size - 1 || playerCol < 0 || playerRow < 0 || playerRow > size - 1)
                {
                    initialString.Remove(initialString.Length - 2, 1);
                }

                if (char.IsLetter(matrix[playerRow, playerCol]))
                {

                    initialString.Append(matrix[playerRow, playerCol].ToString());
                    matrix[playerCol, playerRow] = '-';
                }
            }

            PrintMatrix(matrix);
            Console.WriteLine(initialString.ToString().TrimEnd());

        }

        private static void PrintMatrix(char[,] matrix)
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
