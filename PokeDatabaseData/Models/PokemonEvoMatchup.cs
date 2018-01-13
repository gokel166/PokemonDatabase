using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDatabaseData.Models
{
    public class PokemonEvoMatchup
    {
        public virtual Pokemon PokId { get; set; }
        public int EvoFromSpecId { get; set; }
        public virtual PokemonHabitats HabitatId { get; set; }
        public int GenderRate { get; set; }
        public int CaptureRate { get; set; }
        public int BaseHappiness { get; set; }
    }
}
