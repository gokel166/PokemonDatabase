using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PokeDatabaseData.Models
{
    public class PokemonMoves
    {
        public virtual Pokemon PokId { get; set; }
        public int VersionGroupId { get; set; }
        public virtual Moves MoveId { get; set; }
        public virtual PokemonMoveMethods MethodId { get; set; }
        public int Level { get; set; }
    }
}
