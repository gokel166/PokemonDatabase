using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDatabaseData.Models
{
    public class TypeEfficacy
    {
        public int DamageType { get; set; }
        public int TargetTypeId { get; set; }
        public int DamageFactor { get; set; }
    }
}
