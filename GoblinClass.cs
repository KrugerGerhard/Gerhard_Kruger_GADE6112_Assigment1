using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question 2.5 
namespace Gerhard_Kruger_19343413_GADE6112_Assigment1_GoblinSlayer
{
    //GoblinClass inherits from the EnemyClass
    class GoblinClass : EnemyClass
    {
        //Constructor
        public GoblinClass(int x, int y) : base(x, y, 1, 10, 'G')
        {

        }

        //Method for returning move
        public override Movement ReturnMove(Movement move = 0)
        {
            //Initialising variable. Default = no movement
            //Movement move = 0;

            //Randomise 0 - 4 (4 means that the enemy does not move)
            int randomNum = rnd.Next(0, 4 + 1);
            //REFERENCE
            while (!(vision[0].GetType().Name.Equals(nameof(EmptyTileClass))))
            {
                randomNum = rnd.Next(1, 4 + 1);
            }

            switch (randomNum)
            {
                case 0:
                    move = Movement.Up;
                    break;
                case 1:
                    move = Movement.Right;
                    break;
                case 2:
                    move = Movement.Down;
                    break;
                case 3:
                    move = Movement.Left;
                    break;
                case 4:
                    move = Movement.None;
                    break;
            }

            return move;
        }
    }
}
