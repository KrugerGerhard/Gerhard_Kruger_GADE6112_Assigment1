using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question 3.3
namespace Gerhard_Kruger_19343413_GADE6112_Assigment1_GoblinSlayer
{
    class GameEngineForm
    {
        //Declarations of char
        private MapClass map;
        private static readonly char hero = 'H';
        private static readonly char empty = '.';
        private static readonly char goblin = 'G';
        private static readonly char obstacle = 'X';

        //Map object constructor
        public GameEngineForm(int minWidth, int maxWidth, int minHeight, int maxHeight, int numOfEnemies)
        {
            map = new MapClass (minWidth, maxWidth, minHeight, maxHeight, numOfEnemies);
        }

        //Properties for the construtor above
        public MapClass Map
        {
            get { return Map; }
            set { map = value; }
        }

        //Method for player movement
        public bool MovePlayer(CharacterClass.Movement direction)
        {
            if (map.Hero.ReturnMove(direction) == CharacterClass.Movement.None)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
//Sorry Kirsten, I called a fat GG with Question 3 & 4, Hella sleep deprived and I literally can't anymore. Have fun marking and I'm extremely sorry, my bad:) 
    }
}
