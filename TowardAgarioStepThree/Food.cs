using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Communications;

namespace TowardAgarioStepThree
{
    internal class Food
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public int ARGBColor { get; private set; }
        public float Mass { get; private set; }

        [JsonConstructor]
        public Food(float X, float Y, int ARGBcolor, float mass)
        {
            this.X = X;
            this.Y = Y;
            this.ARGBColor = ARGBcolor;
            this.Mass = mass;
        }

    }
}