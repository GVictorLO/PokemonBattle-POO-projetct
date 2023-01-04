using System.Text.Json;
using ConsoleApp1.Moves;
using ConsoleApp1.Pokemons;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var charmander  = new Charmander();
            var bulbassauro = new Bulbassauro();
            //var text = JsonSerializer.Serialize(eve);
            //Console.WriteLine(text);

            //var pokemon = JsonSerializer.Deserialize<Pokemon>(text);
            //if (pokemon.Name == "Eve") 
            //{
            //    var deserializedPokemon = JsonSerializer.Deserialize<Eve>(text);
            //}
            var battle = new Battle(bulbassauro, charmander);

            battle.Run();
        }
    }
}