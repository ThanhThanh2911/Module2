using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonApp.Domain
{
    public class PokemonBattle
    {
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public int BattleId { get; set; }
        public Battle Battle { get; set; }

    }
}
