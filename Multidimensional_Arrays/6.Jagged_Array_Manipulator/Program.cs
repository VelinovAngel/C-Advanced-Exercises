using System;
using System.Linq;

namespace _6.Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] colsValue = Console
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();
                jaggedArr[row] = new int[colsValue.Length];

                for (int col = 0; col < colsValue.Length; col++)
                {
                    jaggedArr[row][col] = colsValue[col];
                }
            }

            ;

        }
    }
}
