using System;
using System.Collections.Generic;

namespace OnePieceApp.Domain
{
    public class Clan
    {
        public Clan()
        {
            Characters = new List<Character>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Character> Characters { get; set; }
    }
}
