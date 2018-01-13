using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDatabaseData.Models
{
    public class BaseStats
    {
        public virtual Pokemon PokId { get; set; }
        public int BaseHp { get; set; }
        public int BaseAtk { get; set; }
        public int BaseDef { get; set; }
        public int BaseSpa { get; set; }
        public int BaseSpdef { get; set; }
        public int BaseSpeed { get; set; }
    }
}
