using System;
using System.Collections.Generic;

namespace _8.Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());

            string cars = string.Empty;
            Queue<string> queue = new Queue<string>();
            int count = 0;

            while ((cars = Console.ReadLine()) != "end")
            {
                if (cars != "green")
                {
                    queue.Enqueue(cars);
                }
                else if (cars == "green")
                {
                    for (int i = 0; i < numOfCars; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;

                        }
                    }
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
