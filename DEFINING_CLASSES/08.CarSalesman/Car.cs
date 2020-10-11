using System;
using System.Text;

namespace _08.CarSalesman
{
    public class Car
    {
        public Car(string model,Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, double weight)
            :this(model,engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            :this(model,engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, double weight,string color)
            :this(model,engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        //•	Model
        //•	Engine
        //•	Weight 
        //•	Color

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double? Weight { get; set; }
        public string Color { get; set; }

        //{CarModel}:
        //  {EngineModel}:
        //Power: { EnginePower}
        //Displacement: { EngineDisplacement}
        //Efficiency: { EngineEfficiency}
        //Weight: { CarWeight}
        //Color: { CarColor}


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string weightStr = this.Weight.HasValue ? this.Weight.ToString() : "n/a";
            string colorStr = String.IsNullOrEmpty(this.Color) ? "n/a" : this.Color;

            sb.AppendLine($"{this.Model}:")
                .AppendLine($"  {this.Engine}:")
                .AppendLine($"  Weight: {weightStr}")
                .AppendLine($"  Color: {colorStr}");

            return sb.ToString().TrimEnd();

        }
    }

}
