using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Pokemons;

namespace ConsoleApp1.Moves
{
    internal class Move
    {
        public int MoveId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int NumMoves { get; set; }
        public PokemonType Type { get; set; }
        public string Effect { get; set; } = string.Empty;
        public decimal Damage { get; set; }
        public decimal Accuracy { get; set; } = decimal.Zero;
        public AtackCategory Category { get; set; }

        public virtual decimal ExecuteMove(Pokemon ataPokemon, Pokemon defPokemon)
        {
            if (Category == AtackCategory.Physical)
            {
                Console.WriteLine("** It's a physical atack **");
                var damage = ataPokemon.Atack * Damage / defPokemon.Defense;
                var Effect = MoveEffectCalculator.CalculateEffect(Type, defPokemon.Type);
                if (Effect == 2)
                {
                    Console.WriteLine("It's super effective!");
                }
                damage *= Effect;
                defPokemon.Hp -= Convert.ToInt32(damage);
                return damage;
            }
            else if (Category == AtackCategory.Special)
            {
                Console.WriteLine("** It's a special atack **");
                var damage = ataPokemon.SpAtack * Damage / defPokemon.SpDefense;
                var Effect = MoveEffectCalculator.CalculateEffect(Type, defPokemon.Type);
                if (Effect == 2)
                {
                    Console.WriteLine("It's super effective!");
                }
                damage *= Effect;
                defPokemon.Hp -= Convert.ToInt32(damage);
                return damage;
            }
            return 0;
        }
    }
}
