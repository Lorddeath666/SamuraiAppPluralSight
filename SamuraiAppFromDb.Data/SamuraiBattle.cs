using System;
using System.Collections.Generic;

namespace SamuraiAppFromDb.Data
{
    public partial class SamuraiBattle
    {
        public int SamuraiId { get; set; }
        public int BattleId { get; set; }

        public Battles Battle { get; set; }
        public Samurais Samurai { get; set; }
    }
}
