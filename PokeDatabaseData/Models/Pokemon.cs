using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDatabaseData.Models
{
    public class Pokemon
    {
        public int PokId { get; set; }
        public string PokName { get; set; }
        public int SpeciesId { get; set; }
        public double Height { get; set; }
        public decimal Weight { get; set; }
        public int BaseExp { get; set; }
    }
}
