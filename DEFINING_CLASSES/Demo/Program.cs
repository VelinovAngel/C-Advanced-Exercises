using System;
using System.Linq;
using System.Collections.Generic;
namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string[] input = Console.ReadLine().Split(); //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
            while (!input.Contains("Tournament"))
            {
                string trainerName = input[0];

                string pokemonName = input[1];
                string pokemonElement = input[2];
                double pokemonHealth = double.Parse(input[3]);


                Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer(trainerName, newPokemon);
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, trainer);
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(newPokemon);
                }

                input = Console.ReadLine().Split();
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    bool isDead = false;
                    foreach (var pokemon in trainer.Value.Pokemons)
                    {
                        if (pokemon.Element == command)
                        {
                            trainer.Value.NumberOfBadges++;
                            break;
                        }
                        else
                        {
                            pokemon.Health -= 10;
                            if (pokemon.Health <= 0)
                            {
                                isDead = true;
                            }
                        }
                    }
                    if (isDead)
                    {
                        trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }

                }

                command = Console.ReadLine();
            }

            var sortedTrainers = trainers.OrderByDescending(x => x.Value.NumberOfBadges);
            foreach (var trainer in sortedTrainers)
            {
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.NumberOfBadges} {trainer.Value.Pokemons.Count}");
            }

        }
    }
}