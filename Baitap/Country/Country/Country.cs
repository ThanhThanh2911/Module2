using System;
using System.Collections.Generic;
using System.Text;

namespace Country
{
    class Country
    {
        private string name;
        private string code;
        private string region;
        private int population;

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public string Region { get => region; set => region = value; }
        public int Population { get => population; set => population = value; }

        public Country()
        {

        }

        public Country(string name, string code, string region, int population)
        {
            Name = name;
            Code = code;
            Region = region;
            Population = population;
        }
    }
}
