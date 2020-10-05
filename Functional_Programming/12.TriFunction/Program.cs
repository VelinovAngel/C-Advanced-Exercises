using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int> GetAschiiSum = p => p.Select(c => (int)c).Sum();
            //{
            //    int result = 0;
            //    for (int i = 0; i < p.Length; i++)
            //    {
            //        result += p[i];
            //    }
            //    return result;

            //};
            //string person = GetName(people, n, GetAschiiSum);
            //Console.WriteLine(person);

            Func<List<string>, int, Func<string, int>, string> nameFunc =
                (person, n, func) => people.FirstOrDefault(p => func(p) >= n);

            string result = nameFunc(people, n, GetAschiiSum);
            Console.WriteLine(result);
        }

        static string GetName(List<string> people, int n, Func<string, int> func)
        {
            string result = null;
            foreach (var person in people)
            {
                if (func(person) >= n)
                {
                    result = person;
                }
            }
            return result;
        }
    }
}
