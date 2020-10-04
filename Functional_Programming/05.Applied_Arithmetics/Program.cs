using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> addFunc = x => x + 1;
            Func<int, int> multiplyFunc = x => x * 2;
            Func<int, int> subtractFunc = x => x - 1;

            Action<List<int>> printFunc = x => Console.WriteLine(string.Join(' ', x));

            //•	"add"->add 1 to each number
            //•	"multiply"->multiply each number by 2
            //•	"subtract"->subtract 1 from each number
            //•	"print"->print the collection
            //•	"end"->ends the input

            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                switch (input)
                {
                    case "add":
                        //numbers = numbers.Select(x => addFunc(x)).ToList();
                        numbers = numbers.Select(addFunc).ToList();
                        break;
                    case "multiply":
                        numbers = numbers.Select(multiplyFunc).ToList();
                        break;
                    case "subtract":
                        numbers = numbers.Select(subtractFunc).ToList();
                        break;
                    case "print":
                        printFunc(numbers);
                        break;
                }
            }
        }
    }
}
