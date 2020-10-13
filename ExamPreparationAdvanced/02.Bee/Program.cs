using System;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] beeTerritory = new char[n, n];

            int beeRow = -1;
            int beeCol = -1;

            ReadMatrix(n, beeTerritory, ref beeRow, ref beeCol);

            int pollinatedFlowers = 0;
            string input = Console.ReadLine();

            while (input != "End")
            {
                //"up", "down", "left", "right",
                beeTerritory[beeRow, beeCol] = '.';

                if (input == "up")
                {
                    beeRow--;
                }
                else if (input == "down")
                {
                    beeRow++;
                }
                else if (input == "left")
                {
                    beeCol--;
                }
                else if (input == "right")
                {
                    beeCol++;
                }

                if (beeCol > n - 1 || beeCol < 0 || beeRow < 0 || beeRow > n - 1)
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                if (beeTerritory[beeRow, beeCol] == 'f')
                {
                    pollinatedFlowers++;
                }
                else if (beeTerritory[beeRow, beeCol] == 'O')
                {
                    continue;
                }

                input = Console.ReadLine();
            }
            if (input == "End")
            {
                beeTerritory[beeRow, beeCol] = '.';
                beeTerritory[beeRow, beeCol] = 'B';
            }

            if (pollinatedFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }

            PrintMatrix(n, beeTerritory);
        }

        private static void PrintMatrix(int n, char[,] beeTerritory)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(beeTerritory[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(int n, char[,] beeTerritory, ref int beeRow, ref int beeCol)
        {
            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    beeTerritory[row, col] = currentRow[col];
                    if (currentRow[col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }
        }
    }
}
