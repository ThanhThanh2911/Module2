using System;
using System.Collections.Generic;
using System.Text;

namespace Verhicles
{
    class Bike : Vehicle
    {
        private double speed;
        private int iD ;
        

        public Bike()
        {
        }

        public Bike(string make, string model, string year) : base(make, model, year)
        {
        }

        public double Speed { get => speed; set => speed = value; }
        public int ID { get => iD ; set => iD = value; }

        public override string ToString()
        {
            return ID + Speed + Make + Model + Year;
        }

    }
}
