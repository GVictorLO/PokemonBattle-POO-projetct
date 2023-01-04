using ConsoleApp1.Migrations;
using ConsoleApp1.Moves;
using ConsoleApp1.Players;
using ConsoleApp1.Pokemons;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PokedexContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Players.UserPokemons> UsersPokemons { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Encrypt=False;User ID=GVictorLO/GVictor;Initial Catalog=Pokemon;Data Source=GVICTORLO\\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Players.UserPokemons>(entity =>
            {
                entity.HasKey(p => new {p.PokemonId, p.PlayerId});
            });
        }
    }
    
}
