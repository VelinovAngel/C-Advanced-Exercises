using System;
using System.Linq;

namespace _4.Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string symbol = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = symbol[col];
                }

            }

            char findSymbol = char.Parse(Console.ReadLine());

            bool isFind = false;

            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == findSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFind = true;
                        return;
                    }

                }
                
            }

            if (!isFind)
            {
                Console.WriteLine($"{findSymbol} does not occur in the matrix ");
            }
        }
    }
}
