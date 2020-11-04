using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Vehicle
    {
        //FIELDS
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        //PROPERTIES
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Vehicle(string make, string model, string year, float weight)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Weight = _weight;
        }

        public Vehicle() { }

        public override string ToString()
        {
            return string.Format("A " + Year +  Make +  Model + " has a GVW of " + Weight + ".");
        }
    }
}
