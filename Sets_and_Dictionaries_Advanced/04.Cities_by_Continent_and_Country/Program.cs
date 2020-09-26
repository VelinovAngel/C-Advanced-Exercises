using System;
using System.Collections.Generic;

namespace _04.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents =
                  new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                    if (!continents[continent].ContainsKey(country))
                    {
                        continents[continent].Add(country, new List<string>());
                        if (!continents[continent][country].Contains(city))
                        {
                            continents[continent][country].Add(city);
                        }
                        else
                        {
                            continents[continent][country].Add(city);
                        }
                    }
                }
                else
                {
                    if (!continents[continent].ContainsKey(country))
                    {
                        continents[continent].Add(country, new List<string>());
                        if (!continents[continent][country].Contains(city))
                        {
                            continents[continent][country].Add(city);
                        }
                        else
                        {
                            continents[continent][country].Add(city);
                        }
                    }
                    else
                    {
                        continents[continent][country].Add(city);
                    }
                }

            }

            foreach (var kvp in continents)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
                }
            }

        }
    }
}
