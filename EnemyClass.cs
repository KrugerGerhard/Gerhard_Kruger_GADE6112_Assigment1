using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question 2.4
namespace Gerhard_Kruger_19343413_GADE6112_Assigment1_GoblinSlayer
{
    //Class inherits from CharacterClass
    abstract class EnemyClass : CharacterClass
    {
        protected Random rnd;

        public EnemyClass(int x, int y, int enemyDamage, int hp, char symbol) : base(x, y, symbol)
        {
            this.damage = enemyDamage;
            this.hp = hp;
            this.maxHP = hp;
        }

        //Enemy string output method that returns
        public override string ToString()
        {
            return $"{this.GetType().Name} at [{this.X + 1},{this.Y + 1}] ({this.Damage})";
        }
    }
}
