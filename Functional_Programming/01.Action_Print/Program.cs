using System;

namespace _01.Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            //Action<string> print = x => Console.WriteLine(x);
            Action<string[]> printNames = x =>
            Console.WriteLine(string.Join(Environment.NewLine, x));
            printNames(input);
            //for (int i = 0; i < input.Length; i++)
            //{
            //    print(input[i]);
            //}
        }
    }
}
