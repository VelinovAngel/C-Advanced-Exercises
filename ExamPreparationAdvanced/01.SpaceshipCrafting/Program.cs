using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> materials = new Dictionary<int, string>()
            {
                {25,"Glass" },
                {50,"Aluminium" },
                {75,"Lithium" },
                {100,"Carbon fiber" },
            };

            Dictionary<string, int> result = new Dictionary<string, int>()
            {
                {"Glass",0 },
                {"Aluminium",0 },
                {"Lithium",0 },
                {"Carbon fiber",0 },
            };

            int[] inputLiquids = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] inputItems = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> liquids = new Queue<int>(inputLiquids);
            Stack<int> items = new Stack<int>(inputItems);

            while (liquids.Count > 0 && items.Count > 0)
            {
                int liquidAmount = liquids.Peek();
                int itemAmount = items.Peek();

                int sumForMaterial = liquidAmount + itemAmount;

                if (materials.ContainsKey(sumForMaterial))
                {
                    string materialName = materials[sumForMaterial];
                    result[materialName] += 1;

                    liquids.Dequeue();
                    items.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    int itemResult = items.Pop() + 3;
                    items.Push(itemResult);
                }
            }

            if (result.All(x => x.Value >= 1))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't enough materials to build the spaceship");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }

            if (items.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", items)}");
            }

            foreach (var (key,value) in result.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{key}: {value}");
            }
        }
    }
}
