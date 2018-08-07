using Adventura.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventura.Character
{
    class Player : Human
    {
        public int currentXP = 0;
        public int XPtoLevelUp = 10;
        public List<Item.Item> inventory = new List<Item.Item>();

        public Player(string name, int maxHP, int level, int minDmg = 0, int maxDmg = 15)
        {
            this.name = name;
            this.maxHP = maxHP;
            currentHP = maxHP;
            this.level = level;
            this.minDmg = minDmg;
            this.maxDmg = maxDmg;
        }


    }
}
