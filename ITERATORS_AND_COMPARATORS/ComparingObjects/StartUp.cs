using System;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person a = new Person("Gosho", 13, "Sofia");
            Person b = new Person("Gosho", 14, "Burgas");

            Console.WriteLine(a.CompareTo(b));
        }
    }
}
