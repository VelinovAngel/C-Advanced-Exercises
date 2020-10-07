using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tiresStore = new List<Tire[]>();
            string tire = string.Empty;
            while ((tire = Console.ReadLine()) != "No more tires")
            {
                string[] tokens = tire.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Tire[] currTires = new Tire[4]
                {
                    new Tire(int.Parse(tokens[0]), double.Parse(tokens[1])),
                    new Tire(int.Parse(tokens[2]), double.Parse(tokens[3])),
                    new Tire(int.Parse(tokens[4]), double.Parse(tokens[5])),
                    new Tire(int.Parse(tokens[6]), double.Parse(tokens[7])),
                };

                tiresStore.Add(currTires);
                //2 2.6 3 1.6 2 3.6 3 1.6
            }

            string engine = string.Empty;
            List<Engine> engines = new List<Engine>();
            while ((engine = Console.ReadLine()) != "Engines done")
            {
                //331 2.2
                string[] tokens = engine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);

                Engine currEngine = new Engine(horsePower, cubicCapacity);

                engines.Add(currEngine);
            }

            List<Car> cars = new List<Car>();
            string special = string.Empty;
            while ((special = Console.ReadLine()) != "Show special")
            {
                string[] tokens = special.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                //{make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}

                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tireIndex = int.Parse(tokens[6]);

                if ((engineIndex >= 0 && engineIndex < engines.Count)
                    &&
                    (tireIndex >= 0 && tireIndex < tiresStore.Count))
                {
                    Car currCar = new Car
                    (make, model, year, fuelQuantity, fuelConsumption,
                    engines[engineIndex], tiresStore[tireIndex]);

                    cars.Add(currCar);
                }
            }

            cars = cars.Where(x => x.Year >= 2017
            && x.Engine.HorsePower > 330
            && x.Tires.Sum(y => y.Pressure) >= 9
            && x.Tires.Sum(y => y.Pressure) <= 10).ToList();

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    car.Drive(20.00);
                    Console.WriteLine(car.WhoAmI());
                }
            }

        }
    }
}
