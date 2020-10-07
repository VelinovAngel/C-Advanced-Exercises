namespace CarManufacturer
{
    public class Engine
    {
        public Engine(int horsepower, double cubicCapacity)
        {
            this.CubicCapacity = cubicCapacity;
            this.HorsePower = horsepower;
        }

        public int HorsePower { get; set; }

        public double CubicCapacity { get; set; }
    }
}
