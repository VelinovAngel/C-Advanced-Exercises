using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private List<Present> presents;

        public Bag(string color, int capacity)
        {
            Color = color;
            Capacity = capacity;
            presents = new List<Present>();
        }

        public int Count
            => presents.Count;

        public string Color { get; set; }

        public int Capacity { get; set; }


        public void Add(Present present)
        {
            if (presents.Count < Capacity)
            {
                presents.Add(present);
            }
        }

        public bool Remove(string name)
        {
            return presents.Remove(presents.FirstOrDefault(x => x.Name == name));
        }

        public Present GetHeaviestPresent()
        {
            return presents.FirstOrDefault(x => x.Weight == presents.Max(x => x.Weight));
        }

        public Present GetPresent(string name)
        {
            return presents.FirstOrDefault(x => x.Name == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Color} bag contains:");

            foreach (var present in presents)
            {
                sb.AppendLine($"{present}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
