using System;
using System.Collections.Generic;

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
            int maxAge = int.MinValue;
            Person person = null;

            foreach (var item in People)
            {
                int currAge = item.Age;

                if (currAge > maxAge)
                {
                    maxAge = currAge;
                    person = item;
                }
            }

            return person;
            
        }
    }
}
