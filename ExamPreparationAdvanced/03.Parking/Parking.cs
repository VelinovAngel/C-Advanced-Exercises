using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> cars;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            this.cars = new List<Car>();
        }

        public int Count
            => cars.Count;
        //•	Type: string
        //•	Capacity: int

        public string Type { get; set; }

        public int Capacity { get; set; }


        public void Add(Car car)
        {
            if (cars.Count < Capacity)
            {
                cars.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car car = cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            return cars.Remove(car);
        }

        public Car GetLatestCar()
        {
            Car car = cars.FirstOrDefault(x => x.Year == cars.Max(x => x.Year));

            return car;
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car car = cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);

            return car;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");
            foreach (var car in cars)
            {
                sb.AppendLine($"{car}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
