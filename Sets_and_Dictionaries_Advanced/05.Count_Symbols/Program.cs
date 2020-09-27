using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> store = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!store.ContainsKey(input[i]))
                {
                    store.Add(input[i], 0);
                }
                store[input[i]] += 1;
            }

            foreach (var kvp in store.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
