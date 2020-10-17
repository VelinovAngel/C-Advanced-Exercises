using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> astronauts;

        public int Count
            => this.astronauts.Count;

        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.astronauts = new List<Astronaut>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }


        public void Add(Astronaut astronaut)
        {
            if (astronauts.Count < this.Capacity)
            {
                astronauts.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            Astronaut astronaut = astronauts.FirstOrDefault(x => x.Name == name);

            if (astronaut == null)
            {
                return false;
            }
            else
            {
                astronauts.Remove(astronaut);
                return true;
            }
        }

        public Astronaut GetOldestAstronaut()
        {
            //Astronaut astronaut = astronauts.OrderByDescending(x => x.Age).FirstOrDefault();
            return astronauts.FirstOrDefault(x => x.Age == astronauts.Max(x => x.Age));
        }

        public Astronaut GetAstronaut(string name)
        {         
            return astronauts.FirstOrDefault(x => x.Name == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");
            foreach (var astronaut in astronauts)
            {
                sb.AppendLine($"{astronaut}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
