using System;
using System.Collections.Generic;

namespace _07.SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string party = string.Empty;

            HashSet<string> numbers = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();


            while ((party = Console.ReadLine()) != "PARTY")
            {
                string code = party;
                if (char.IsDigit(code[0]))
                {
                    vip.Add(code);
                }
                else
                {
                    numbers.Add(code);

                }

            }

            string end = string.Empty;

            while ((end = Console.ReadLine()) != "END")
            {
                string vipCode = end;
                if (numbers.Contains(vipCode))
                {
                    numbers.Remove(vipCode);
                }
                if (vip.Contains(vipCode))
                {
                    vip.Remove(vipCode);
                }
            }

            Console.WriteLine(numbers.Count + vip.Count);

            if (vip.Count>0)
            {
                foreach (var item in vip)
                {
                    Console.WriteLine(item);
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
