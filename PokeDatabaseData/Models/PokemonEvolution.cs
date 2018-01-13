using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDatabaseData.Models
{
    public class PokemonEvolution
    {
        public int EvolveId { get; set; }
        public int EvolvesSpecId { get; set; }
        public int EvolveMinLevel { get; set; }
    }
}
