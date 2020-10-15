using System;

namespace _07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string personFullName = $"{tokens[0]} {tokens[1]}";
            string personAdress = tokens[2];


            Tuple<string, string> personInfo = new Tuple<string, string>(personFullName, personAdress);

            string[] secondTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string personName = secondTokens[0];
            int beerLiters = int.Parse(secondTokens[1]);

            Tuple<string, int> personBeerInfo = new Tuple<string, int>(personName, beerLiters);

            string[] thirdTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int intValues = int.Parse(thirdTokens[0]);
            double doubleValue = double.Parse(thirdTokens[1]);

            Tuple<int, double> numbersInfo = new Tuple<int, double>(intValues, doubleValue);

            Console.WriteLine(personInfo);
            Console.WriteLine(personBeerInfo);
            Console.WriteLine(numbersInfo);


        }
    }
}
