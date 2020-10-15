using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Generic_Swap_Method_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> values = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string currName = Console.ReadLine();

                values.Add(currName);
            }

            int[] inputItems = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = inputItems[0];
            int secondIndex = inputItems[1];

            Box<string> box = new Box<string>(values);
            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box); 
        }
    }
}
