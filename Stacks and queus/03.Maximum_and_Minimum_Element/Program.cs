using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 x – Push the element x into the stack.
            //2 – Delete the element present at the top of the stack.
            //3 – Print the maximum element in the stack.
            //4 – Print the minimum element in the stack.

            int line = int.Parse(Console.ReadLine());
            Stack<int> sequence = new Stack<int>();


            for (int i = 0; i < line; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (numbers[0] == 1)
                {
                    sequence.Push(numbers[1]);
                }
                else if (numbers[0] == 2)
                {
                    if (sequence.Count > 0)
                    {
                        sequence.Pop();

                    }
                }
                else if (numbers[0] == 3)
                {
                    if (sequence.Count > 0)
                    {
                        Console.WriteLine(sequence.Max());
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (numbers[0] == 4)
                {
                    if (sequence.Count > 0)
                    {
                        Console.WriteLine(sequence.Min());
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", sequence));

        }
    }
}
