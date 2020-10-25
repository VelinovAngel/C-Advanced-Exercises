using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taskItems = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] threadsItems = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int taskValue = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(taskItems);
            Queue<int> queue = new Queue<int>(threadsItems);


            while (true)
            {
                int task = stack.Peek();
                int threads = queue.Peek();
                int sum = task + threads;

                if (task == taskValue)
                {
                    Console.WriteLine($"Thread with value {threads} killed task {taskValue}");
                    break;
                }

                if (threads >= task)
                {
                    stack.Pop();
                    queue.Dequeue();
                    continue;
                }

                if (threads < task)
                {
                    queue.Dequeue();
                    continue;
                }
            }


            if (queue.Count > 0)
            {
                Console.WriteLine($"{string.Join(" ", queue)}");
            }
        }
    }
}
