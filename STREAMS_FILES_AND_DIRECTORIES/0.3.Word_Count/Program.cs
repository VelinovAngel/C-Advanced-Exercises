using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _0._3.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            //words.txt - pattern
            string[] pattern = File.ReadAllLines("../../../words.txt");

            //text.txt - input
            string[] inputText = File.ReadAllLines("../../../text.txt");

            Dictionary<string, int> actualResult = new Dictionary<string, int>();
            MergeFils(pattern, inputText, actualResult);

            //actualResult.txt - result

            using (StreamWriter writer = new StreamWriter("../../../actualResult.txt"))
            {
                foreach (var kvp in actualResult)
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }

            //expectedResult.txt - ordered result

            using (StreamWriter writer = new StreamWriter("../../../expectedResult.txt"))
            {
                foreach (var kvp in actualResult.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }

        private static void MergeFils(string[] pattern, string[] inputText, Dictionary<string, int> actualResult)
        {
            for (int i = 0; i < inputText.Length; i++)
            {
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (inputText[i].ToLower().Contains(pattern[j].ToLower()))
                    {
                        if (!actualResult.ContainsKey(pattern[j]))
                        {
                            actualResult.Add(pattern[j], 0);
                        }
                        actualResult[pattern[j]]++;
                    }
                }
            }
        }
    }
}
