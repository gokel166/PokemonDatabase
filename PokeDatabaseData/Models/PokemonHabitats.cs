using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PokeDatabaseData.Models
{
    public class PokemonHabitats
    {
        public int HabitatId { get; set; }
        public string HabitatName { get; set; }
        public string HabitatDescription { get; set; }
    }
}
