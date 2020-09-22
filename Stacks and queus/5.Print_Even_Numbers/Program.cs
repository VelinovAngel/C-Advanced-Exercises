using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);
            string output = string.Empty;
            while (queue.Count > 0)
            {
                int item = queue.Peek();
                if (item % 2 == 0)
                {
                    output += queue.Dequeue() + ", ";

                }
                else
                {
                    queue.Dequeue();
                }
            }

            Console.WriteLine(output.Substring(0, output.Length - 2));
        }
    }
}
