using ConsoleApp1.Moves;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pokemons
{
    internal class Bulbassauro : Pokemon
    {
        public Bulbassauro()
        {
            Id = 1;
            Name = "Bulbassauro";
            Type = PokemonType.Grass;
            Atack = 10;
            SpAtack = 10;
            Defense = 10;
            SpDefense = 10;
            Speed = 20;
            Hp = 80;
            MaxHp = 80;
            Moves = new List<Move>
                {
                    new Takle(),
                    new Absorb(),
                };
        }
    }
}
