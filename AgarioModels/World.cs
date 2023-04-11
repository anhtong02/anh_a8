using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgarioModels
{
    /// <summary>
    /// responsible for tracking these (but not limited to) : width, height, list of players in game,
    /// list of food in the game, logger
    /// </summary>
    internal class World
    {
        private const int Width = 5000;
        private const int Height = 5000;
        HashSet<Player> _players; //can switch to dictionary<int id, string name>
        HashSet<Food> _foods;

        private ILogger _loggger;
    }
}
