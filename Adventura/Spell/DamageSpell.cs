using System;
using System.Collections.Generic;
using System.Text;

namespace Adventura.Spell
{
    public class DamageSpell : Spell
    {
        public int minDmg;
        public int maxDmg;


        public DamageSpell(int minDmg, int maxDmg, MagicClass magicClass)
        {
            this.minDmg = minDmg;
            this.maxDmg = maxDmg;
            this.magicClass = magicClass;
        }
    }
}
