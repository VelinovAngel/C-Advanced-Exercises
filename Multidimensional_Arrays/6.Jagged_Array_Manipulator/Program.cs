using System;
using System.Linq;

namespace _6.Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArr = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] colsValue = Console
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => double.Parse(x))
                    .ToArray();
                //jaggedArr[row] = colsValue;

                jaggedArr[row] = new double[colsValue.Length];

                for (int col = 0; col < colsValue.Length; col++)
                {
                    jaggedArr[row][col] = colsValue[col];
                }
            }


            for (int row = 0; row < rows - 1; row++)
            {
                double[] rowOne = jaggedArr[row];
                double[] rowTwo = jaggedArr[row + 1];

                if (rowOne.Length == rowTwo.Length)
                {
                    jaggedArr[row] = rowOne.Select(x => x * 2).ToArray();
                    jaggedArr[row + 1] = rowTwo.Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedArr[row] = rowOne.Select(x => x / 2).ToArray();
                    jaggedArr[row + 1] = rowTwo.Select(x => x / 2).ToArray();
                }

            }


            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {

                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (!isValidCell(jaggedArr,row,col))
                {
                    continue;
                }


                if (command == "Add")
                {
                    jaggedArr[row][col] += value;
                }
                else if (command == "Subtract")
                {
                    jaggedArr[row][col] -= value;
                }
            }

            foreach (var item in jaggedArr)
            {
                Console.WriteLine(string.Join(' ',item));
            }
        }

        private static bool isValidCell(double[][] jaggedArr, int row, int col)
        {
            return row >= 0 && row < jaggedArr.Length && col >= 0 && col < jaggedArr[row].Length;
        }
    }
}
