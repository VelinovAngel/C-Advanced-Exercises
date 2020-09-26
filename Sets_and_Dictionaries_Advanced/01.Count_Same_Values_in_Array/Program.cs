using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> times = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!times.ContainsKey(numbers[i]))
                {
                    times.Add(numbers[i], 0);
                }

                times[numbers[i]] += 1;
            }

            foreach (var kvp in times)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
