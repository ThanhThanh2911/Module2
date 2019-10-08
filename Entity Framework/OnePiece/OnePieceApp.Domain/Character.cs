using System;
using System.Collections.Generic;
using System.Text;

namespace OnePieceApp.Domain
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Description { get; set; }
        public int ClanId { get; set; }
        public int DevilFruitId { get; set; }
        public Clan Clan { get; set; }
        public DevilFruit DevilFruit { get; set; }

    }
}
