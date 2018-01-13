using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDatabaseData.Models
{
    public class Abilities
    {
        public virtual PokemonAbility AbilityId { get; set; }
        public string AbilityName { get; set; }
    }
}
