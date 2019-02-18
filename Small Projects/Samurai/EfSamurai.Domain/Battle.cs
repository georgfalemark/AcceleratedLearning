using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Brutal { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public BattleLog BattleLog { get; set; }
    }
}
