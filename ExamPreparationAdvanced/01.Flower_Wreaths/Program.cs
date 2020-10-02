using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] roses = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries) // queue 
                .Select(int.Parse)
                .ToArray();
            int[] lilies = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries) // stack
                .Select(int.Parse)
                .ToArray();

            //10, 15, 2, 7, 9, 13
            //2, 10, 8, 12, 0, 5
            //the last lilies and the first roses

            Stack<int> stackRoses = new Stack<int>(roses);
            Queue<int> queueLilies = new Queue<int>(lilies);

            int wreathCount = 0;
            int storeFlowers = 0;

            while (stackRoses.Count > 0 && queueLilies.Count > 0)
            {
                int currRose = stackRoses.Peek();
                int currLilie = queueLilies.Peek();
                int currSum = currRose + currLilie;

                if (currSum == 15)
                {
                    stackRoses.Pop();
                    queueLilies.Dequeue();
                    wreathCount++;
                }
                else if (currSum > 15)
                {
                    while (currSum > 15)
                    {
                        currSum = currRose + (currLilie);
                        currLilie--;
                        currLilie--;
                    }
                    stackRoses.Pop();
                    queueLilies.Dequeue();
                    wreathCount++;
                }
                else if (currSum < 15)
                {
                    storeFlowers += stackRoses.Pop() + queueLilies.Dequeue();
                }
            }

            while (storeFlowers >= 15)
            {
                wreathCount++;
                storeFlowers -= 15;
            }
            //Console.WriteLine(storeFlowers);

            if (wreathCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathCount} wreaths more!");
            }
        }
    }
}
