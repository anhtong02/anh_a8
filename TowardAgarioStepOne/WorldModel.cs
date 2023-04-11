using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TowardAgarioStepOne
{
    internal class WorldModel
    {
        public int x;
        public int y;
        public int radius;
        public Vector2 direction;
        private double windowWidth;
        private double windowHeight;

        public WorldModel(int radius, double windowWidth, double windowHeight)
        {
            this.x = 100;
            this.y = 100;
            this.radius = radius;
            this.direction = new Vector2(50, 25);
            this.windowWidth = windowWidth;
            this.windowHeight = windowHeight;
        }


        public void AdvanceGameOneStep()
        {
            this.x += (int)direction.X;
            this.y += (int)direction.Y;

            if (this.x >= this.windowWidth || this.x <= 0)
            {
                direction.X *= -1;
            }
            if (this.y >= this.windowHeight || this.y <= 0)
            {
                direction.Y *= -1;
            }
        }
    }
}