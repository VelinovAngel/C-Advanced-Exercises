using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            //"{color} -> {item1},{item2},{item3}…"

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();


            for (int i = 0; i < n; i++)
            {
                string[] items = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = items[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                    for (int j = 1; j < items.Length; j++)
                    {
                        if (!wardrobe[color].ContainsKey(items[j]))
                        {
                            wardrobe[color].Add(items[j], 0);
                        }
                        wardrobe[color][items[j]] += 1;
                    }
                }
                else
                {
                    for (int j = 1; j < items.Length; j++)
                    {
                        if (!wardrobe[color].ContainsKey(items[j]))
                        {
                            wardrobe[color].Add(items[j], 0);
                        }
                        wardrobe[color][items[j]] += 1;
                    }
                }

            }

            string input = Console.ReadLine();

            string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var item in kvp.Value)
                {

                    if (item.Key == command[1] && kvp.Key == command[0])
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }


                }
            }
        }
    }
}
