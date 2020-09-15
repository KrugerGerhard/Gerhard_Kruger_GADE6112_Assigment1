using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question 2.6
namespace Gerhard_Kruger_19343413_GADE6112_Assigment1_GoblinSlayer
{
    class HeroClass : CharacterClass
    {
        public HeroClass(int x, int y, int hp, int damage) : base(x, y, 'H')
        {
            this.hp = hp;
            this.maxHP = hp;
            this.damage = 2;
        }

        //returning movememnt method
        public override Movement ReturnMove(Movement move)
        {
            bool validMove = false;

            //vision array: up = 0; right = 1; down = 2; left = 3;
            switch (move)
            {
                case Movement.Up:
                    if (vision[0].GetType().Name.Equals(nameof(EmptyTileClass))) { validMove = true; }
                    break;
                case Movement.Right:
                    if (vision[1].GetType().Name.Equals(nameof(EmptyTileClass))) { validMove = true; }
                    break;
                case Movement.Down:
                    if (vision[2].GetType().Name.Equals(nameof(EmptyTileClass))) { validMove = true; }
                    break;
                case Movement.Left:
                    if (vision[3].GetType().Name.Equals(nameof(EmptyTileClass))) { validMove = true; }
                    break;
            }

            if (validMove)
            {
                return move;
            }
            else
            {
                return Movement.None;
            }
        }

        //hero returning string display information
        public override string ToString()
        {
            return $"Player Stats: \nHP: {this.HP}/{this.MaxHP} HP \nDamage: {this.Damage} \n[{this.X + 1},{this.Y + 1}]";
        }
    }
}
