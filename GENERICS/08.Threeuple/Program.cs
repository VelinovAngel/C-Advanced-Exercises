using System;

namespace _08.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokensPerson = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //{first name} {last name} {address} {town}

            string firstNameAndLastName = $"{tokensPerson[0]} {tokensPerson[1]}";
            string address = tokensPerson[2];
            string town = string.Empty;
            if (tokensPerson.Length == 5)
            {
                town = $"{tokensPerson[3]} {tokensPerson[4]}";

            }
            else if (tokensPerson.Length < 5)
            {
                town = $"{tokensPerson[3]}";

            }

            Threeuple<string, string, string> personInfo = new Threeuple<string, string, string>(firstNameAndLastName, address, town);


            string[] tokensBeer = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //{name} {liters of beer} {drunk or not}

            string name = tokensBeer[0];
            int litersOfBeer = int.Parse(tokensBeer[1]);
            string drunkOrNot = tokensBeer[2];
            bool isDrunk = true;
            if (drunkOrNot == "drunk")
            {
                isDrunk = true;
            }
            else if (drunkOrNot == "not")
            {
                isDrunk = false;
            }

            Threeuple<string, int, bool> infoBeer = new Threeuple<string, int, bool>(name, litersOfBeer, isDrunk);

            string[] tokensBank = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //{name} {account balance} {bank name}

            string bankName = tokensBank[0];
            double balance = double.Parse(tokensBank[1]);
            string value = tokensBank[2];

            Threeuple<string, double, string> infoBank = new Threeuple<string, double, string>(bankName, balance, value);

            Console.WriteLine(personInfo);
            Console.WriteLine(infoBeer);
            Console.WriteLine(infoBank);

        }
    }
}
