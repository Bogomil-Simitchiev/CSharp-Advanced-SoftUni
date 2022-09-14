using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        public Cargo(string type , double weigth)
        {
            Type = type;
            Weigth = weigth;
        }
        public string Type { get; set; }
        public double Weigth { get; set; }
    }
}
