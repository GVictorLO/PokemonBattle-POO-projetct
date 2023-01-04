using ConsoleApp1.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pokemons
{
    internal class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public PokemonType Type { get; set; }
        public decimal Atack { get; set; } = 20;
        public decimal SpAtack { get; set; }
        public decimal Speed { get; set; } = 10;
        public decimal Defense { get; set; }
        public decimal SpDefense { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public List<Move> Moves { get; set; } = new List<Move>();
    }
}
