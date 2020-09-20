using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> clothesValues = new Stack<int>(inputValues);

            int sum = 0;
            int racks = 1;

            while (clothesValues.Count > 0)
            {
                if (sum + clothesValues.Peek() <= capacity)
                {
                    sum += clothesValues.Pop();
                }
                else
                {
                    sum = 0;
                    racks++;
                }
            }

            Console.WriteLine(racks);

        }
    }
}
