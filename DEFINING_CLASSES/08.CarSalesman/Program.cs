using System;
using System.Collections.Generic;

namespace _08.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            HashSet<Engine> engines = new HashSet<Engine>();
            //"{model} {power} {displacement} {efficiency}"
            //  V8-101   220       50

            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = inputInfo[0];
                int power = int.Parse(inputInfo[1]);
                int displacement = int.Parse(inputInfo[2]);
                string efficiency = inputInfo[3];

            }



            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] inputInfo = Console.ReadLine()
                    .Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                //"{model} {engine} {weight} {color}"

                //FordFocus        V4-33      1300     Silver
                //FordMustang      V8 - 101
                //VolkswagenGolf   V4-33               Orange

                string model = inputInfo[0];
                int weight = int.Parse(inputInfo[2]);
                string color = inputInfo[3];
                string engine = inputInfo[1];




            }

        }

    }
}
