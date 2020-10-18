using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstToken = Console.ReadLine()
                .Split();

            string personFullName = $"{firstToken[0]} {firstToken[1]}";
            string personAdress = firstToken[2];

            Tuple<string, string> personInfo = new Tuple<string, string>(personFullName, personAdress);

            string[] secondTokens = Console.ReadLine()
                .Split();

            string personName = secondTokens[0];
            int beerLiters = int.Parse(secondTokens[1]);

            Tuple<string, int> personBeerInfo = new Tuple<string, int>(personName,beerLiters);

            string[] thirdTokens = Console.ReadLine()
                .Split();

            int intValues = int.Parse(thirdTokens[0]);
            double doubleValue = double.Parse(thirdTokens[1]);

            Tuple<int, double> numbersInfo = new Tuple<int, double>(intValues, doubleValue);

            Console.WriteLine(personInfo);
            Console.WriteLine(personBeerInfo);
            Console.WriteLine(numbersInfo);
        }
    }
}
