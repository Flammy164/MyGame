using System;
using System.Collections.Generic;
using System.Text;

namespace Adventura.Character
{
    class Animal : Character
    {
        public bool hostileToPlayer;

        public Animal(string name, int maxHP, int level, int worthXP, int minDmg = 0, int maxDmg = 15, bool hostileToPlayer = false)
        {
            this.name = name;
            this.maxHP = maxHP;
            this.level = level;
            this.worthXP = worthXP;
            this.minDmg = minDmg;
            this.maxDmg = maxDmg;
        }
    }
}
