using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Generic_Swap_Method_Integer
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> value = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());

                value.Add(currNum);
            }

            int[] inputItems = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = inputItems[0];
            int secondIndex = inputItems[1];


            Box<int> values = new Box<int>(value);
            values.Swap(firstIndex, secondIndex);

            Console.WriteLine(values);
            
        }
    }
}
