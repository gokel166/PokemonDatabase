using System;
using Microsoft.EntityFrameworkCore;

namespace PokeDatabaseData
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions options) : base(options) { }

        public DbSet<PokemonContext> Pokemons { get; set; }
    }
}
