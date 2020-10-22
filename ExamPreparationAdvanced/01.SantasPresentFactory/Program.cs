using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SantasPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Doll    150
            //Wooden train    250
            //Teddy bear  300
            //Bicycle     400
            const int Doll = 150;
            const int WoodenTrain = 250;
            const int TeddyBear = 300;
            const int Bicycle = 400;


            Dictionary<string, int> box = new Dictionary<string, int>()
            {
                {"Doll" , 0 },
                {"Wooden train",0 },
                {"Teddy bear", 0 },
                {"Bicycle",0 }
            };

            int[] materials = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] magicLevel = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(materials);
            Queue<int> queue = new Queue<int>(magicLevel);

            while (stack.Count > 0 && queue.Count > 0)
            {
                int materialElement = stack.Peek();
                int magicMaterial = queue.Peek();
                int product = materialElement * magicMaterial;

                if ((box["Doll"] == 1 && box["Wooden train"] == 1) ||
                    (box["Teddy bear"] == 1 && box["Bicycle"] == 1))
                {
                    Console.WriteLine("The presents are crafted! Merry Christmas!");
                    break;
                }

                switch (product)
                {
                    case Doll:
                        box["Doll"]++;
                        stack.Pop();
                        queue.Dequeue();
                        break;
                    case WoodenTrain:
                        box["Wooden train"]++;
                        stack.Pop();
                        queue.Dequeue();
                        break;
                    case TeddyBear:
                        box["Teddy bear"]++;
                        stack.Pop();
                        queue.Dequeue();
                        break;
                    case Bicycle:
                        box["Bicycle"]++;
                        stack.Pop();
                        queue.Dequeue();
                        break;
                    default:
                        if (product < 0)
                        {
                            int sum = materialElement + magicMaterial;
                            stack.Pop();
                            queue.Dequeue();
                            stack.Push(sum);
                        }
                        else if (product > 0)
                        {
                            queue.Dequeue();
                            stack.Push(stack.Pop() + 15);
                        }
                        else if (product == 0)
                        {
                            stack.Pop();
                            queue.Dequeue();
                        }
                        break;
                }
            }

            if (stack.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ", stack)}");
            }

            if (queue.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", queue)}");
            }

            foreach (var (key, value) in box.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{key}: {value}");
            }

        }
    }

}


