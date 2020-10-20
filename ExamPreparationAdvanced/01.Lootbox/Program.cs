using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] itemsQueue = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] inputStack = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(itemsQueue);
            Stack<int> stack = new Stack<int>(inputStack);

            int totalSum = 0;

            while (queue.Count > 0 && stack.Count > 0)
            {
                int currIntQueue = queue.Peek();
                int currIntStack = stack.Peek();
                int sum = currIntStack + currIntQueue;

                if (sum % 2 == 0)
                {
                    totalSum += sum;
                    queue.Dequeue();
                    stack.Pop();
                }
                else
                {
                    queue.Enqueue(stack.Pop());
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (totalSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {totalSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {totalSum}");
            }
        }
    }
}
