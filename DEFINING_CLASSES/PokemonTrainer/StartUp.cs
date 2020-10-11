using System;
using System.Collections.Generic;

namespace PokemonTrainer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<Trainers, Pokemon> trainersList = new Dictionary<Trainers, Pokemon>();

            //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"

            //Tournament


            string infoTrainer = string.Empty;
            while ((infoTrainer = Console.ReadLine()) != "Tournament")
            {
                string[] argoTrainer = infoTrainer
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string trainerName = argoTrainer[0];
                string pokemonName = argoTrainer[1];
                string pokemonElement = argoTrainer[2];
                int pokemonHealth = int.Parse(argoTrainer[3]);

                Trainers trainers = new Trainers(trainerName);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainersList.ContainsKey(trainers))
                {
                    trainersList.Add(trainers, pokemon);
                }
                else
                {
                    trainersList[trainers].Name += 1;
                }



            }
        }
    }
}
