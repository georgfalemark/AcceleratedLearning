using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class BattleEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public BattleLog BattleLog { get; set; }

    }
}
