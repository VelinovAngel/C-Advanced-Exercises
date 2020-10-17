using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DaturaBombs = 40;
            const int CherryBombs = 60;
            const int SmokeDecoyBombs = 120;

            Dictionary<string, int> elements = new Dictionary<string, int>()
            {
                {"Datura Bombs",0 },
                {"Cherry Bombs",0 },
                {"Smoke Decoy Bombs",0 }
            };

            int[] queueElements = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] stackElements = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> effects = new Queue<int>(queueElements);
            Stack<int> casing = new Stack<int>(stackElements);
            //5, 25, 50, 115
            //5, 15, 25, 35


            //•	Datura Bombs: 40
            //•	Cherry Bombs: 60
            //•	Smoke Decoy Bombs: 120

            while (effects.Count > 0 && casing.Count > 0)
            {
                int currEffects = effects.Peek();
                int currCasing = casing.Peek();
                int sumElements = currEffects + currCasing;

                if (elements.All(x => x.Value >= 3))
                {
                    break;
                }
                switch (sumElements)
                {
                    case DaturaBombs:
                        elements["Datura Bombs"]++;
                        effects.Dequeue();
                        casing.Pop();
                        break;
                    case CherryBombs:
                        elements["Cherry Bombs"]++;
                        effects.Dequeue();
                        casing.Pop();
                        break;
                    case SmokeDecoyBombs:
                        elements["Smoke Decoy Bombs"]++;
                        effects.Dequeue();
                        casing.Pop();
                        break;
                    default:
                        casing.Push(casing.Pop() - 5);
                        break;

                }
            }

            if (elements.All(x => x.Value >= 3))
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effects.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (casing.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casing)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach (var (key, value) in elements.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{key}: {value}");
            }


        }
    }
}
