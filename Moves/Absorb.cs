using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using ConsoleApp1.Pokemons;

namespace ConsoleApp1.Moves
{
    internal class Absorb : Move
    {
        public Absorb()
        {
            MoveId = 0;
            Name = "Absorb";
            Damage = 30;
            Type = PokemonType.Grass;
            Category = AtackCategory.Special;
        }

        public override decimal ExecuteMove(Pokemon ataPokemon, Pokemon defPokemon)
        {
            var damage = base.ExecuteMove(ataPokemon, defPokemon);
            var heal = damage / 2;
            ataPokemon.Hp += Convert.ToInt32(heal);

            return damage;
        }
    }
}
