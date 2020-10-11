using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            HashSet<Engine> engines = new HashSet<Engine>();
            AddEngines(n, engines);

            int m = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            AddCar(engines, m, cars);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }

        private static void AddCar(HashSet<Engine> engines, int m, List<Car> cars)
        {
            for (int i = 0; i < m; i++)
            {
                string[] inputInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                //"{model} {engine} {weight} {color}"

                //FordFocus        V4-33      1300     Silver
                //FordMustang      V8 - 101
                //VolkswagenGolf   V4-33               Orange
                Car car = null;

                string model = inputInfo[0];
                Engine engine = engines.First(e => e.Model == inputInfo[1]);


                if (inputInfo.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if (inputInfo.Length == 3)
                {
                    double weight;
                    bool isWeight = double.TryParse(inputInfo[2], out weight);
                    if (isWeight)
                    {
                        car = new Car(model, engine, weight);

                    }
                    else
                    {
                        car = new Car(model, engine, inputInfo[2]);
                    }
                }
                else if (inputInfo.Length == 4)
                {
                    int weight = int.Parse(inputInfo[2]);
                    string color = inputInfo[3];
                    car = new Car(model, engine, weight, color);
                }

                if (car != null)
                {
                    cars.Add(car);
                }
            }
        }

        private static void AddEngines(int n, HashSet<Engine> engines)
        {
            for (int i = 0; i < n; i++)
            {
                //"{model} {power} {displacement} {efficiency}"
                //  V8-101   220       50
                string[] inputInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Engine engine = null;

                string model = inputInfo[0];
                int power = int.Parse(inputInfo[1]);
                if (inputInfo.Length == 4)
                {
                    int displacement = int.Parse(inputInfo[2]);
                    string efficiency = inputInfo[3];

                    engine = new Engine(model, power, displacement, efficiency);
                }
                else if (inputInfo.Length == 3)
                {
                    int displacement;
                    bool isDisplacement = int.TryParse(inputInfo[2], out displacement);

                    if (isDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, inputInfo[2]);
                    }

                }
                else if (inputInfo.Length == 2)
                {
                    engine = new Engine(model, power);
                }

                if (engine != null)
                {

                    engines.Add(engine);
                }

            }
        }
    }
}
