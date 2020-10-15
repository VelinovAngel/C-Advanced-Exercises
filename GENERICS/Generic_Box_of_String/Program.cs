using System;

namespace Generic_Box_of_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currString = Console.ReadLine();
                Box<string> box = new Box<string>(currString);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
