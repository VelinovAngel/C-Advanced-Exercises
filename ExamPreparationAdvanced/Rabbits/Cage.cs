using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> rabbits;

        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            rabbits = new List<Rabbit>();
        }

        public int Count
            => rabbits.Count;

        public string Name { get; set; }

        public int Capacity { get; set; }

        public void Add(Rabbit rabbit)
        {
            if (rabbits.Count < Capacity)
            {
                rabbits.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            return rabbits.Remove(rabbits.FirstOrDefault(x => x.Name == name));
        }

        public void RemoveSpecies(string species)
        {
            rabbits.RemoveAll(x => x.Species == species);
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = rabbits.FirstOrDefault(x => x.Name == name);
            rabbit.Available = false;
            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabbs = rabbits.Where(x => x.Species == species).ToArray();
            foreach (var rabbit in rabbs)
            {
                rabbit.Available = false;
            }
            return rabbs;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rabbits available at {Name}:");
            foreach (var rabbit in rabbits.Where(x=>x.Available != false))
            {
                sb.AppendLine($"{rabbit}");
            }

            return sb.ToString().TrimEnd();

        }
    }
}
