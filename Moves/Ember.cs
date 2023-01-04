using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Pokemons;

namespace ConsoleApp1.Moves
{
    internal class Ember : Move
    {
        public Ember()
        {
            MoveId = 1;
            Name = "Ember";
            Damage = 40;
            Type = PokemonType.Fire;
            Category = AtackCategory.Special;
            Accuracy = 100;
            NumMoves = 25;
            Effect = "May burn opponent.";
        }
        public override decimal ExecuteMove(Pokemon ataPokemon, Pokemon defPokemon)
        {
            var damage = base.ExecuteMove(ataPokemon, defPokemon);
            var burn = damage / 10;
            ataPokemon.Hp -= Convert.ToInt32(burn);

            return damage;
        }
    }
}
