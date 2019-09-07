using System;
using System.Collections.Generic;
using System.Text;

namespace Verhicles
{
    class Vehicle
    {
        private string _make;
        private string _model;
        private string _year;

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public string Year { get => _year; set => _year = value; }

        public Vehicle()
        {

        }
        public Vehicle(string make, string model, string year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public virtual string ToString()
        {
            return Make + Model + Year;
        }
    }
}
