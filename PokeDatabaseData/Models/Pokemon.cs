using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDatabaseData.Models
{
    public class Pokemon
    {
        public int pokId { get; set; }
        public string pokName { get; set; }
        public int SpeciesId { get; set; }
        public double height { get; set; }
        public decimal Weight { get; set; }
        public int baseExp { get; set; }
    }
}
