using System;
namespace Rabbits
{
    public class Rabbit
    {
        private bool available = true;

        public Rabbit(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public string Name { get; set; }

        public string Species { get; set; }

        public bool Available
        {
            get
            {
                return available;
            }
            set
            {
                available = value;
            }
        }

        public override string ToString()
        {
            return $"Rabbit ({Species}): {Name}";
        }

    }
}
