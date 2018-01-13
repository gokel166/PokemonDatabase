using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDatabaseData.Models
{
    public class PokemonMoves
    {
        public virtual Pokemon PokId { get; set; }
        public int VersionGroupId { get; set; }
        public int MoveId { get; set; }
        public virtual PokemonMoveMethods MethodId { get; set; }
    }
}
