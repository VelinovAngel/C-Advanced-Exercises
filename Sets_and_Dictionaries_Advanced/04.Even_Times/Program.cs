using System;
using System.Collections.Generic;

namespace _04.Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> store = new Dictionary<int, int>();


            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (!store.ContainsKey(numbers))
                {
                    store.Add(numbers, 0);
                }

                store[numbers] += 1;
            }

            foreach (var item in store)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
