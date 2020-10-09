using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] splittedInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                //AudiA4 23 0.3

                string model = splittedInput[0];
                double fuelAmount = double.Parse(splittedInput[1]);
                double fuelConsumption = double.Parse(splittedInput[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);

            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = data[1];
                int amountOfKm = int.Parse(data[2]);

                Car car = GetCar(cars, model);

                car.Drive(amountOfKm);

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }

        }

        private static Car GetCar(List<Car> cars, string model)
        {
            foreach (var car in cars)
            {
                if (car.Model == model)
                {
                    return car;
                }
            }
                    return null;
        }
    }
}
