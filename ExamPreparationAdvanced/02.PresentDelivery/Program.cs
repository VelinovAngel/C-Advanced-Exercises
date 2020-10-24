using System;
using System.Linq;

namespace _02.PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPresents = int.Parse(Console.ReadLine());

            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int santaRow = 0;
            int santaCol = 0;
            int countKids = 0;

            bool hasPresents = false;

            ReadMatrix(matrix, ref santaRow, ref santaCol, ref countKids);

            bool isFinished = false;
            int presentKids = countKids;
            int kidsNice = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Christmas morning")
            {
                matrix[santaRow, santaCol] = '-';

                switch (input)
                {
                    case "up":
                        santaRow--;
                        break;
                    case "down":
                        santaRow++;
                        break;
                    case "right":
                        santaCol++;
                        break;
                    case "left":
                        santaCol--;
                        break;
                    default:
                        break;
                }

                if (matrix[santaRow, santaCol] == 'X')
                {
                    continue;
                }

                if (matrix[santaRow, santaCol] == 'V')
                {
                    countKids--;
                    countPresents--;
                    kidsNice++;
                    if (countPresents == 0)
                    {
                        hasPresents = true;
                        isFinished = true;
                        break;
                    }
                    isFinished = true;
                }

                if (matrix[santaRow, santaCol] == 'C')
                {
                    if (matrix[santaRow - 1, santaCol] != '-')
                    {
                        countPresents--;
                        if (matrix[santaRow - 1, santaCol] == 'V')
                        {
                            matrix[santaRow - 1, santaCol] = '-';
                            kidsNice++;
                        }
                        else
                        {
                            matrix[santaRow - 1, santaCol] = '-';
                        }
                        if (countPresents == 0)
                        {
                            hasPresents = true;
                            isFinished = true;
                            break;
                        }
                    }
                    if (matrix[santaRow + 1, santaCol] != '-')
                    {
                        countPresents--;
                        if (matrix[santaRow + 1, santaCol] == 'V')
                        {
                            matrix[santaRow + 1, santaCol] = '-';
                            kidsNice++;
                        }
                        else
                        {
                            matrix[santaRow + 1, santaCol] = '-';
                        }
                        if (countPresents == 0)
                        {
                            hasPresents = true;
                            isFinished = true;
                            break;
                        }
                    }
                    if (matrix[santaRow, santaCol - 1] != '-')
                    {
                        countPresents--;
                        if (matrix[santaRow, santaCol - 1] == 'V')
                        {
                            matrix[santaRow, santaCol - 1] = '-';
                            kidsNice++;
                        }
                        else
                        {
                            matrix[santaRow, santaCol -1] = '-';
                        }
                        if (countPresents == 0)
                        {
                            hasPresents = true;
                            isFinished = true;
                            break;
                        }
                    }
                    if (matrix[santaRow, santaCol + 1] != '-')
                    {
                        countPresents--;
                        if (matrix[santaRow, santaCol + 1] == 'V')
                        {
                            matrix[santaRow, santaCol + 1] = '-';
                            kidsNice++;
                        }
                        else
                        {
                            matrix[santaRow, santaCol + 1] = '-';
                        }
                        if (countPresents == 0)
                        {
                            hasPresents = true;
                            isFinished = true;
                            break;
                        }
                    }
                }

                matrix[santaRow, santaCol] = 'S';
                //if (IsOutside(size, santaRow, santaCol))
                //{
                //    Console.WriteLine("Santa ran out of presents!");
                //    PrintMatrix(matrix);
                //    break;
                //}
                //PrintMatrix(matrix);
            }

            if (hasPresents)
            {
                matrix[santaRow, santaCol] = 'S';
                Console.WriteLine("Santa ran out of presents!");
            }

            PrintMatrix(matrix);

            if (isFinished)
            {

                if (kidsNice == presentKids)
                {
                    Console.WriteLine($"Good job, Santa! {kidsNice} happy nice kid/s.");
                }
                else
                {
                    Console.WriteLine($"No presents for {presentKids - kidsNice} nice kid/s.");
                }
            }
        }

        static void ReadMatrix(char[,] matrix, ref int santaRow, ref int santaCol, ref int count)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] line = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                    if (line[col] == 'S')
                    {
                        santaRow = row;
                        santaCol = col;
                    }
                    if (line[col] == 'V')
                    {
                        count++;
                    }
                }
            }
        }

        static void PrintMatrix(char[,] matrix)
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

        private static bool IsOutside(int size, int santaRow, int santaCol)
        {
            return santaRow >= size ||
                    santaRow < 0 ||
                    santaCol >= size ||
                    santaCol < 0;
        }
    }
}
