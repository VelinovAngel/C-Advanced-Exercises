using System;

namespace _02.SpaceStation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }

        }
    }
}
