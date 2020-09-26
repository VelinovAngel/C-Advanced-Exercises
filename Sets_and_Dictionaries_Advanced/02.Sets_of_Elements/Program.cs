using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = numbers[0];
            int m = numbers[1];
            HashSet<int> firstNum = new HashSet<int>();
            HashSet<int> secondNum = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int numberOne = int.Parse(Console.ReadLine());
                firstNum.Add(numberOne);
            }

            for (int i = 0; i < m; i++)
            {
                int numberSec = int.Parse(Console.ReadLine());
                secondNum.Add(numberSec);
            }

            foreach (var item in firstNum)
            {
                if (firstNum.Contains(item) && secondNum.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }

        }
    }
}
