using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            int start = input[0];
            int end = input[1];

            Func<int, int, List<int>> generateList = (start, end) =>
              {
                  List<int> nums = new List<int>();
                  for (int i = start; i <= end; i++)
                  {
                      nums.Add(i);
                  }
                  return nums;
              };

            List<int> numbers = generateList(start, end);

            Predicate<int> predicate = n => n % 2 == 0;
            //Func<int, bool> evenPredicate = n => n % 2 == 0;

            //numbers = numbers.Where(evenPredicate).ToList();

            if (command == "odd")
            {
                predicate = n => n % 2 != 0;
            }

            numbers = MyWhere(numbers, predicate);
            
            Console.WriteLine(string.Join(' ', numbers));
        }

        static List<int> MyWhere(List<int> items, Predicate<int> predicate)
        {
            List<int> result = new List<int>();

            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
