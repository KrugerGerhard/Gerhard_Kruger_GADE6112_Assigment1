using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////Question 2.1
namespace Gerhard_Kruger_19343413_GADE6112_Assigment1_GoblinSlayer
{
    //Class that serves as the base for Tiles
    abstract class TileClass
    {
        protected int x;
        protected int y;
        protected TileType tileType;

        public TileClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public enum TileType
        {
            Hero,
            Enemy,
            Gold, 
            Weapon,
        }

        //Vaulues
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public TileType TheTileType
        {
            get { return tileType; }
            set { tileType = value; }

        }

    }
}
