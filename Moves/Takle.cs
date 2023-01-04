using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ConsoleApp1.Moves
{
    internal class Takle : Move
    {
        public Takle()
        {
            MoveId = 2;
            Name = "Takle";
            Damage = 40;
            Type = PokemonType.Normal;
            Category = AtackCategory.Physical;
            Accuracy = 100;
            NumMoves = 35;

        }
    }
}
