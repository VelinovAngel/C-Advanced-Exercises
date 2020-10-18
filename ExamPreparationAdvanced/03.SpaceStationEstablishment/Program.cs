using System;

namespace _03.SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] field = new char[size][];
            int stephanRow = 0;
            int stephanCol = 0;

            for (int row = 0; row < size; row++)
            {
                field[row] = new char[size];
                char[] currCol = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    char ch = currCol[col];

                    if (ch == 'S')
                    {
                        stephanRow = row;
                        stephanCol = col;

                    }

                    field[row][col] = ch;
                }
            }
            int stars = 0;

            while (true)
            {
                field[stephanRow][stephanCol] = '-';
                string command = Console.ReadLine();

                switch (command)
                {
                    case "right":
                        stephanCol++;
                        break;
                    case "left":
                        stephanCol--;
                        break;
                    case "up":
                        stephanRow--;
                        break;
                    case "down":
                        stephanRow++;
                        break;
                }

                bool isOutside = IsOutside(size, stephanRow, stephanCol);
                if (isOutside)
                {
                    Console.WriteLine("Bad news, the spaceship went to the void");
                    break;
                }

                char element = field[stephanRow][stephanCol];
                if (element == 'O')
                {
                    field[stephanRow][stephanCol] = '-';

                    for (int row = 0; row < size; row++)
                    {
                        bool found = false;
                        for (int col = 0; col < size; col++)
                        {
                            char currMatrixElement = field[row][col];

                            if (currMatrixElement == 'O')
                            {
                                stephanRow = row;
                                stephanCol = col;

                                field[stephanRow][stephanCol] = 'S';

                                found = true;
                                break;
                            }
                        }
                        if (found)
                        {
                            break;
                        }
                    }
                }
                else if (char.IsDigit(element))
                {
                    stars += int.Parse(element.ToString());
                    // stars += element - '0'; Using ASCHII Table

                    if (stars >= 50)
                    {
                        Console.WriteLine("Good news! Stephen succeeded in collecting enought star power!");
                        break;
                    }
                }
            }

            Console.WriteLine($"Star power collected: {stars}");

            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field.Length; col++)
                {
                    Console.Write(field[row][col]);
                }
                Console.WriteLine();
            }

        }

        private static bool IsOutside(int size, int stephanRow, int stephanCol)
        {
            return stephanRow >= size ||
                    stephanRow < 0 ||
                    stephanCol >= size ||
                    stephanCol < 0;
        }
    }
}
