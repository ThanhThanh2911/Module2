using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonApp.Domain
{
    public class Note
    {
        public int ID { get; set; }
        public string Text { get; set; }

        //public Pokemon Pokemon { get; set; }
        public int PokemonID { get; set; }
    }
}
