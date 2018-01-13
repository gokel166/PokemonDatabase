using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDatabaseData.Models
{
    public class Moves
    {
        public int MoveId { get; set; }
        public string MoveName{ get; set; }
        public virtual Type TypeId { get; set; }
        public byte MovePower { get; set; }
        public byte MovePP { get; set; }
        public byte MoveAccuracy { get; set; }
    }
}
