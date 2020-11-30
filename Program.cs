using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
    class Obstacle : Tile //Class for the obstacle tile
    {
        //Constructor
        public Obstacle (int x, int y) : base(x, y, 'X')
        {

        }

    }
    
}
