using System;
namespace PokemonTrainer
{
    public class Trainers
    {
        private int numberOfBadges = 0;

        public Trainers(string name)
        {
            Name = name;

        }

        public Trainers(string name, int numberOfBadges, int aCollectionOfPokemon)
            :this(name)
        {
            NumberOfBadges = numberOfBadges;
            ACollectionOfPokemon = aCollectionOfPokemon;
        }


        //•	Name
        //•	Number of badges
        //•	A collection of pokemon


        public string Name { get; set; }

        public int NumberOfBadges
        {
            get { return  numberOfBadges; }
            set { numberOfBadges = 0; }
        }

        public int  ACollectionOfPokemon { get; set; }
    }
}
