using System;
namespace PokemonTrainer
{
    public class Pokemon
    {
        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }

        //•	Name
        //•	Element
        //•	Health

        public string Name { get; set; }

        public string Element { get; set; }

        public int Health { get; set; }



    }
}
