using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PokeDatabaseData.Models
{
    public class PokemonTypes
    {
        public virtual Pokemon PokId { get; set; }
        [Required]
        public int TypeId { get; set; }
        public int Slot { get; set; }
    }
}
