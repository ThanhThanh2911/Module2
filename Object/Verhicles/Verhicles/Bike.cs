using System;
using System.Collections.Generic;
using System.Text;

namespace Verhicles
{
    class Bike : Vehicle
    {
        private double speed;

        public Bike()
        {
        }

        public Bike(string make, string model, string year) : base(make, model, year)
        {
        }

        public double Speed { get => speed; set => speed = value; }

        public override string ToString()
        {
            return Speed + Make + Model + Year;
        }

    }
}
