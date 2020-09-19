using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            int numberElement = input[0];
            int removeElement = input[1];
            int checkElement = input[2];

            for (int i = 0; i < removeElement; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(checkElement))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
