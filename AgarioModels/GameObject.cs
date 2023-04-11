using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AgarioModels
{
    [JsonDerivedType(typeof(GameObject), typeDiscriminator: "GameObject")]
    [JsonDerivedType(typeof(Player), typeDiscriminator: "Player")]
    /// <summary>
    /// Represent a game object (food, player, etc)
    /// Cube must at least represent these data: unique id num (long int); location of game obj (x,y); X property; Y property
    /// </summary>
    internal class GameObject
    {
        /// <summary>
        /// The ID of a game object, it should be unique
        /// </summary>
        private long ID { get;}
        /// <summary>
        /// X property. Do not have a setter
        /// </summary>
        private int X { get; }
        /// <summary>
        /// Y property. Do not have a setter.
        /// </summary>
        private int Y { get; set; }
        /// <summary>
        /// Color for display purpose.
        /// </summary>
        public int ARGBColor { get; private set; }
        /// <summary>
        /// Mass to determine how big to draw a circle.
        /// </summary>
        public float Mass { get; private set; }

        public Vector2 direction;

        public GameObject(int ID, int X, int Y, int ARGBColor, float mass, Vector2 direction)
        {
            this.ID = ID;
            this.X = X;
            this.Y = Y;
            this.ARGBColor = ARGBColor;
            this.Mass = mass;
            this.direction = direction;
        }
    }
}
