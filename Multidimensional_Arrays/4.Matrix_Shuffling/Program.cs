using System;
using System.Linq;

namespace _4.Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];
            FillMatrix(matrix);

            string inputCommand = string.Empty;

            while ((inputCommand = Console.ReadLine()) != "END")
            {
                //"swap row1 col1 row2c col2"

                if (!ValidateCommand(inputCommand, rows, cols))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    string[] splittedCommand = inputCommand.Split();
                    int rowIndexFirst = int.Parse(splittedCommand[1]);
                    int colIndexFirst = int.Parse(splittedCommand[2]);
                    int rowIndexSecond = int.Parse(splittedCommand[3]);
                    int colIndexSecond = int.Parse(splittedCommand[4]);

                    string firstElement = matrix[rowIndexFirst, colIndexFirst];
                    string secondElement = matrix[rowIndexSecond, colIndexSecond];


                    matrix[rowIndexFirst, colIndexFirst] = secondElement;
                    matrix[rowIndexSecond, colIndexSecond] = firstElement;
                    //for (int row = 0; row < rows; row++)
                    //{
                    //    for (int col = 0; col < cols; col++)
                    //    {
                    //        if (row == rowIndexFirst && col == colIndexFirst)
                    //        {
                    //            matrix[row, col] = secondElement;
                    //        }
                    //        else if (row == rowIndexSecond && col == colIndexSecond)
                    //        {
                    //            matrix[row, col] = firstElement;
                    //        }
                    //    }
                    //}
                    PrintMatrix(matrix);
                }
            }
        }

        private static bool ValidateCommand(string inputCommand, int rows, int cols)
        {
            //5 elements
            //1 element swap
            //validation rows and cols
            string[] splittedCommand = inputCommand.Split();

            if (splittedCommand.Length == 5 && splittedCommand[0] == "swap"
                && int.Parse(splittedCommand[1]) <= rows && int.Parse(splittedCommand[2]) <= cols
                && int.Parse(splittedCommand[3]) <= rows && int.Parse(splittedCommand[4]) <= cols)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currentRows = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRows[col];
                }
            }
        }

        static void PrintMatrix(string[,] matrix)
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
    }
}
