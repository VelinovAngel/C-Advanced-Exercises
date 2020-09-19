using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            int numberElement = input[0];
            int removeElement = input[1];
            int checkElement = input[2];

            for (int i = 0; i < removeElement; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(checkElement))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
