using System;
using System.Collections.Generic;
using System.Text;

namespace Adventura.Spell
{
    public class HealingSpell : Spell
    {
        public int minHeal;
        public int maxHeal;

        public HealingSpell(int minHeal, int maxHeal, MagicClass magicClass)
        {
            this.minHeal = minHeal;
            this.maxHeal = maxHeal;
            this.magicClass = magicClass;
        }
    }
}
