using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<Person> people = new HashSet<Person>();
            SortedSet<Person> orderedPeople = new SortedSet<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] personArg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = personArg[0];
                int age = int.Parse(personArg[1]);


                Person p = new Person(name, age);

                people.Add(p);
                orderedPeople.Add(p);
            }

            Console.WriteLine(people.Count);
            Console.WriteLine(orderedPeople.Count);
        }
    }
}
