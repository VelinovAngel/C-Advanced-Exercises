using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> divisors = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToList();
            List<int> divisibleNumbers = GetDivisibleNumbers(n, divisors);

            Console.WriteLine(string.Join(" ", divisibleNumbers));
        }

        static List<int> GetDivisibleNumbers(int n, List<int> divisors)
        {
            List<int> divisibleNumbers = new List<int>();

            for (int num = 1; num <= n; num++)
            {
                bool isDivisible = true;

                foreach (var d in divisors)
                {
                    Predicate<int> isNotDivisor = x => num % x != 0;

                    if (isNotDivisor(d))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    divisibleNumbers.Add(num);
                }
            }
            return divisibleNumbers;

        }
    }
}
