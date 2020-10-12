using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

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

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }
                Trainer currTrainer = trainers[trainerName];

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                currTrainer.Pokemons.Add(pokemon);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string element = command;

                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.Value.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                            
                        trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x=>x.Value.Badges))
            {
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
