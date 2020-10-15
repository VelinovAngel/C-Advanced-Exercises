using System;
using System.Collections.Generic;

namespace _05.Generic_Count_Method_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> values = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currString = Console.ReadLine();
                values.Add(currString);
            }

            string value = Console.ReadLine();

            Box<string> box = new Box<string>(values);

            Console.WriteLine(box.GetCountOfGreaterValues(value));
        }
    }
}
