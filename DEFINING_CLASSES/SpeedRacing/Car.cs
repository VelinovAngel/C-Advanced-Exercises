using System;
namespace SpeedRacing
{
    public class Car
    {

        public Car(string model, double fuelAmaount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmaount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }
        //•	string Model
        //•	double FuelAmount
        //•	double FuelConsumptionPerKilometer
        //•	double Travelled distance

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }


        public void Drive(int amountOfKm)
        {
            bool canMove = FuelAmount - (FuelConsumptionPerKilometer * amountOfKm) >= 0;

            if (canMove)
            {
                FuelAmount -= FuelConsumptionPerKilometer * amountOfKm;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }



    }
}
