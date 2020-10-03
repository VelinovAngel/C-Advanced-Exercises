using System;
using System.IO;

namespace _0._2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("../../../text.txt");
            string[] newText = new string[text.Length];

            for (int i = 0; i < text.Length - 1; i++)
            {
                string line = text[i];
                int countSymbols = 0;
                int countPunctuation = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    char symbol = line[j];
                    if (char.IsLetter(symbol))
                    {
                        countSymbols++;
                    }
                    if (char.IsPunctuation(symbol))
                    {
                        countPunctuation++;
                    }
                }
                Console.WriteLine($"Line {i + 1}: {text[i]} ({countSymbols})({countPunctuation})");
                newText[i] = $"Line {i + 1}: {text[i]} ({countSymbols})({countPunctuation})";
                File.WriteAllLines("../../../output.txt", newText);
            }
        }
    }
}
