using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MoveEffectCalculator
    {
        public static decimal CalculateEffect(PokemonType moveType, PokemonType pokemonType)
        {
            if(moveType== PokemonType.Fire && pokemonType == PokemonType.Grass)
            {
                return 2;
            }

            return 1;
        }
    }
}
