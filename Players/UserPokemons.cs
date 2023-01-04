using ConsoleApp1.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Players
{
    internal class UserPokemons
    {
        public int PlayerId { get; set; }
        public Player Players { get; set; }
        public int PokemonId { get; set; }
        public Pokemon Pokemons { get; set; }

    }
}
