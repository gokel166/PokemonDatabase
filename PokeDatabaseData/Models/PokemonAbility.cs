using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDatabaseData.Models
{
    public class PokemonAbility
    {
        public virtual Pokemon PokId { get; set; }
        public int AbilityId { get; set; }
        public int IsHidden { get; set; }
        public int Slot { get; set; }
    }
}
