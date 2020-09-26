using System;
using System.Collections.Generic;

namespace _06.Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            HashSet<string> numbers = new HashSet<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string direction = tokens[0];
                string carPlate = tokens[1];

                if (direction == "IN")
                {
                    numbers.Add(carPlate);
                }
                else if (direction == "OUT")
                {
                    if (numbers.Contains(carPlate))
                    {
                        numbers.Remove(carPlate);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (numbers.Count > 0)
            {
                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}
