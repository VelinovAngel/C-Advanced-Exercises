using System;

namespace _08.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Engine[] engines = new Engine[n];
            //"{model} {power} {displacement} {efficiency}"
            //  V8-101   220       50

            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = inputInfo[0];
                int power = int.Parse(inputInfo[1]);

                if (inputInfo.Length == 1)
                {
                    engines[i] = new Engine(model, power);
                }
                else if (inputInfo.Length == 2)
                {
                    int displacement = int.Parse(inputInfo[2]);
                    engines[i] = new Engine(model, power, displacement);
                }
                else if (inputInfo.Length > 2)
                {
                    int displacement = int.Parse(inputInfo[2]);
                    string efficiency = inputInfo[3];
                    engines[i] = new Engine(model, power, displacement, efficiency);
                }

            }


            int m = int.Parse(Console.ReadLine());
            Car[] cars = new Car[m];

            for (int i = 0; i < m; i++)
            {
                string[] inputInfo = Console.ReadLine()
                    .Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                //"{model} {engine} {weight} {color}" 

                string model = inputInfo[0];
                string engine = inputInfo[1];
                int weight = int.Parse(inputInfo[2]);
                string color = inputInfo[3];

                cars[i] = new Car(model, engine, weight, color);

            }



        }
    }
}
