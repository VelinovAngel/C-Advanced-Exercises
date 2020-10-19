using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            const string END_COMMAND = "END";

            List<Person> people = new List<Person>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != END_COMMAND)
            {
                string[] commArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = commArg[0];
                int age = int.Parse(commArg[1]);
                string town = commArg[2];

                Person p = new Person(name, age, town);

                people.Add(p);
            }

            int n = int.Parse(Console.ReadLine());

            Person comparedPerson = people[n - 1];

            int samePersonCount = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(comparedPerson) == 0)
                {
                    samePersonCount++;
                }
            }

            if (samePersonCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int notSamePeopleCount = people.Count - samePersonCount;
                Console.WriteLine($"{samePersonCount} {notSamePeopleCount} {people.Count}");
            } 
        }
    }
}
