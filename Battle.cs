using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Moves;
using ConsoleApp1.Pokemons;

namespace ConsoleApp1
{
    internal class Battle
    {

        public Battle(Pokemon pokemon1, Pokemon pokemon2) 
        {
            this.pokemon1 = pokemon1;
            this.pokemon2 = pokemon2;
        }

        public Pokemon pokemon1;
        public Pokemon pokemon2;

        private Move ChooseMove(Pokemon pokemon)
        {
            int index = 0;
            Console.WriteLine($"Turno do pokemon {pokemon.Name}");
            foreach (var move in pokemon.Moves)
            {
                Console.WriteLine($"{index}-{move.Name}");
                index++;
            }
            var moveIndex = Console.ReadLine();
            return pokemon.Moves[int.Parse(moveIndex!)];
        }

        private void ShowHP()
        {
            if (pokemon1.Hp >= 0 && pokemon2.Hp >= 0) 
            { 
            Console.WriteLine($"Pokemon {pokemon1.Name} HP:{pokemon1.Hp}/{pokemon1.MaxHp}");
            Console.WriteLine($"Pokemon {pokemon2.Name} HP:{pokemon2.Hp}/{pokemon2.MaxHp}");
            }
            Console.WriteLine("You're pokemon fainted!");
        }
        private void ExecuteRound(Pokemon firstPokemon, Pokemon secondPokemon)
        {
            var move = ChooseMove(firstPokemon);
            move.ExecuteMove(firstPokemon, secondPokemon);
            ShowHP();
            if (secondPokemon.Hp > 0)
            {
                var move2 = ChooseMove(secondPokemon);
                move.ExecuteMove(secondPokemon, firstPokemon);
                ShowHP();
            }
            else
            {
                Console.WriteLine($"Pokemon {secondPokemon.Name} is unable to battle!");
            }
        }
        public void Run()
        {
                Console.WriteLine($"Pokemon {pokemon1.Name} HP:{pokemon1.Hp}/{pokemon1.MaxHp}");
                Console.WriteLine($"Pokemon {pokemon2.Name} HP:{pokemon2.Hp}/{pokemon2.MaxHp}");
            while(pokemon1.Hp > 0 && pokemon2.Hp > 0)
            {
                if (pokemon1.Speed > pokemon2.Speed)
                {
                    ExecuteRound(pokemon1, pokemon2);
                }
                else
                {
                    ExecuteRound(pokemon2, pokemon1);
                }
            }
        }
    }
}
