using System;

namespace _03.SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] field = new char[size][];
            int stephanRow = -1;
            int stephanCol = -1;

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


        }
    }
}
