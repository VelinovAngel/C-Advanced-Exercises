using System;
using System.Collections.Generic;

namespace _03.Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> table = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < input.Length; j++)
                {
                    table.Add(input[j]);
                }
            }

            foreach (var item in table)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
