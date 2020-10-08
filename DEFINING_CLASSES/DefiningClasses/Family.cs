using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            this.People = new List<Person>();
        }
        public List<Person> People { get; set; }


        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            //int maxAge = int.MinValue;
            //Person person = null;

            //foreach (var item in People)
            //{
            //    int currAge = item.Age;

            //    if (currAge > maxAge)
            //    {
            //        maxAge = currAge;
            //        person = item;
            //    }
            //}


            //Person[] oldestPerson = People.OrderByDescending(x => x.Age).ToArray();
            //Person oldestPerson = People.OrderByDescending(x => x.Age).First();

            //return oldestPerson;

            return People.OrderByDescending(x => x.Age).First();

        }

        public Person[] GetPeople()
        {
            Person[] people = People
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToArray();

            return people;
        }
    }
}
