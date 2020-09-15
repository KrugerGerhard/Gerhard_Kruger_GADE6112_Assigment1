using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19343413_GADE6112_Assigment1_GoblinSlayer
{
    abstract class CharacterClass : TileClass
    {
        protected int hp;
        protected int maxHP;
        protected int damage;
        protected TileClass[] vision;
        protected Movement movement;

        public CharacterClass(int x, int y, char symbol) : base(x, y)
        {
            //Up = 0; Right = 1; Down = 2; Left = 3
            vision = new TileClass[4];
        }

        //Movemnet Enums
        public enum Movement
        {
            None, 
            Up, 
            Down, 
            Left, 
            Right
        }

        //info for aforementioned code
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public int MaxHP
        {
            get { return maxHP; }
            set { maxHP = value; }
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public Movement TheMovement
        {
            get { return movement; }
            set { movement = value; }
        }

        public TileClass[] Vision
        {
            get { return vision; }
            set { vision = value; }
        }

        //Damage method//
        public virtual void Attack(CharacterClass target)
        {
            target.hp -= damage;
        }

        //0 HP return method//
        public bool IsDead()
        {
            if (this.HP <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Rangefinder method between target and character
        public virtual bool CheckRange(CharacterClass target)
        {
            int rangeLimit = 1;
            if (DistanceTo(target) == rangeLimit)
            {
                //In range
                return true;
            }
            else
            {
                //Out of range
                return false;
            }
        }

        //Calculation for tile amounts between tiles, including target tile method a target is on
        private int DistanceTo(CharacterClass target)
        {
            int xDistance = Math.Abs(target.X - this.X);
            int yDistance = Math.Abs(target.Y - this.Y);

            return xDistance + yDistance;
        }

        //Character movement method, relates to the x and y.
        public void Move(Movement move)
        {
            switch (move)
            {
                case Movement.Up:
                    this.y--;
                    break;
                case Movement.Down:
                    this.y++;
                    break;
                case Movement.Left:
                    this.x--;
                    break;
                case Movement.Right:
                    this.x++;
                    break;
            }
        }
    }
}
