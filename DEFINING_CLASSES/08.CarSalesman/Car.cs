using System;
namespace _08.CarSalesman
{
    public class Car
    {
        public Car(string model, string engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        //•	Model
        //•	Engine
        //•	Weight 
        //•	Color

        public string Model { get; set; }
        public string Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
    }
}
