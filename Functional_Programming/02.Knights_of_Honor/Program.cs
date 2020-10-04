using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            //Action<string> print = x => Console.WriteLine($"Sir {x}");

            //for (int i = 0; i < names.Length; i++)
            //{
            //    print(names[i]);
            //}
            //names = names.Select(n => $"Sir {n}").ToList();

            names = MySelect(names, n => $"Sir {n}");

            Action<string[]> printNames = x =>
            Console.WriteLine(string.Join(Environment.NewLine, x));

            printNames(names.ToArray());
        }

        static List<string> MySelect(List<string> items, Func<string, string> func)
        {
            List<string> newList = new List<string>();

            foreach (var item in items)
            {
                string newItem = func(item);
                newList.Add(newItem);
            }

            return newList;
        }
    }
}
