using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new Queue<int[]>();

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int[] currPump = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(currPump);
            }

            while (true)
            {
                bool foundPoint = true;
                int fuelAmount = 0;

                for (int i = 0; i < n; i++)
                {
                    int[] currPupm = pumps.Dequeue();
                    fuelAmount += currPupm[0];

                    if (fuelAmount < currPupm[1])
                    {
                        foundPoint = false;
                    }

                    fuelAmount -= currPupm[1];
                    pumps.Enqueue(currPupm);
                }

                if (foundPoint)
                {
                    break;
                }
                count++;

                pumps.Enqueue(pumps.Dequeue());

            }

            Console.WriteLine(count);
        }
    }
}
