using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int[] quantity = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(quantity);
            Console.WriteLine(queue.Max());

            while (queue.Count > 0 && capacity >= 0)
            {
                int currentClient = queue.Peek();
                if (currentClient > capacity)
                {
                    break;
                }

                if (capacity - currentClient >= 0)
                {
                    capacity -= currentClient;
                    queue.Dequeue();
                }
            }

            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }

        }
    }
}
