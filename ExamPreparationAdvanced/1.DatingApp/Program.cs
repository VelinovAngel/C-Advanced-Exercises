using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] female = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] male = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int matched = 0;

            Queue<int> queue = new Queue<int>(female);
            Stack<int> stack = new Stack<int>(male);

            while (queue.Count > 0 && stack.Count > 0)
            {
                int femaleValue = queue.Peek();
                int maleValue = stack.Peek();

                if (femaleValue == maleValue)
                {
                    queue.Dequeue();
                    stack.Pop();
                    matched++;
                }
                else
                {
                    queue.Dequeue();
                    stack.Push(stack.Pop() - 2);
                }

                if (femaleValue <= 0 || maleValue <= 0)
                {
                    if (femaleValue <= 0)
                    {
                        queue.Dequeue();
                    }
                    if (maleValue <= 0)
                    {
                        stack.Pop();
                    }
                }

                if (femaleValue % 25 == 0 || maleValue % 25 == 0)
                {
                    if (femaleValue % 25 == 0)
                    {
                        queue.Dequeue();
                        queue.Dequeue();
                    }
                    if (maleValue % 25 == 0)
                    {
                        stack.Pop();
                        stack.Pop();
                    }
                }
            }

            Console.WriteLine($"Matches: {matched}");

            if (stack.Count == 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ", stack)}");
            }

            if (queue.Count == 0)
            {
                Console.WriteLine($"Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ",queue)}");
            }
        }
    }
}
