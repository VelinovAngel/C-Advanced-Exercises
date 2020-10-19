using System;


namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {

        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
          
        }

        public int CompareTo(Person other)
        {
            //1 -> this is bigger
            //0 -> They are equal
            //-1 -> other is bigger

            //I assum that this is bigger
            int result = 1;

            if (other != null)
            {
                //I start comparing
                result = other.name.CompareTo(this.name);

                if (result == 0)
                {
                    //If my name come first -> 1
                    //They are equal -> 0
                    //Other is first -> -1

                    result = other.age.CompareTo(this.age);

                }
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Person other)
            {
                return this.name == other.name && this.age == other.age;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, age);
        }
    }
}
