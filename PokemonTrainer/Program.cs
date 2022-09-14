using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> dict = new Dictionary<string, Trainer>();

            string command = Console.ReadLine();
            while (command!="Tournament")
            {
                string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = info[0];
                string pokemonName = info[1];
                string pokemonEl = info[2];
                int pokemonHealth = int.Parse(info[3]);
                if (!dict.ContainsKey(trainerName))
                {
                    Trainer newTrainer = new Trainer();
                    newTrainer.Name = trainerName;
                    dict.Add(trainerName, newTrainer);

                }
                Pokemon pokemon = new Pokemon();
                pokemon.Name = pokemonName;
                pokemon.Element = pokemonEl;
                pokemon.Health = pokemonHealth;

                Trainer trainer = dict[trainerName];
                trainer.Pokemons.Add(pokemon);


                command = Console.ReadLine();
            }

            string nextCommand = Console.ReadLine();
            while (nextCommand!="End")
            {

                foreach (var item in dict)
                {
                    if (item.Value.Pokemons.Any(x=>x.Element==nextCommand))
                    {
                        item.Value.Badges += 1;
                    }
                    else
                    {
                        foreach (var item2 in item.Value.Pokemons)
                        {
                            item2.Health -= 10;
                        }
                        item.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }

                nextCommand = Console.ReadLine();
            }
            foreach (var item in dict.OrderByDescending(x=>x.Value.Badges))
            {
                Console.WriteLine($"{item.Key} {item.Value.Badges} {item.Value.Pokemons.Count}");
            }
        }
    }
}
