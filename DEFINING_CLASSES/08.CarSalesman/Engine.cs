using System;
namespace _08.CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, int power, int efficiency)
            : this(model, power)
        {

            this.Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement, int efficiency)
            : this(model, power, displacement)
        {
            this.Displacement = displacement;
        }

        //•	Model
        //•	Power
        //•	Displacement
        //•	Efficiency

        public string Model { get; set; }
        public int Power { get; set; }

        public int Displacement { get; set; }
        public int Efficiency { get; set; }


    }
}
