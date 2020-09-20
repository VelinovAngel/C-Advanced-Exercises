using System;
using System.Linq;

namespace _6.Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] arr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                arr[row] = new int[currentRow.Length];

                for (int col = 0; col < currentRow.Length; col++)
                {
                    arr[row][col] = currentRow[col];
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {

                string[] splittedCommand = command.Split();
                string commandOperator = splittedCommand[0];
                int row = int.Parse(splittedCommand[1]);
                int col = int.Parse(splittedCommand[2]);
                int value = int.Parse(splittedCommand[3]);

                if (row < 0 || row >= arr.Length || col < 0 || col >= arr[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (commandOperator == "Add")
                {
                    arr[row][col] += value;
                }
                else if(commandOperator == "Subtract")
                {
                    arr[row][col] -= value;
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(string.Join(' ',item));
            }
        }
    }
}
