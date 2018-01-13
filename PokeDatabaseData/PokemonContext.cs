using System;
using Microsoft.EntityFrameworkCore;
using PokeDatabaseData.Models;

namespace PokeDatabaseData
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions options) : base(options) { }

        public DbSet<Pokemon> Pokemons { get; set; }
    }
}
