using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] stones = Console.ReadLine()?
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(stones);

            //Console.WriteLine(String.Join(", ", lake));

            List<int> path = new List<int>();
            foreach (var stone in lake)
            {
                path.Add(stone);
            }

            Console.WriteLine(string.Join(", ", path));
        }
    }
}
