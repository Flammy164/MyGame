using System;
using System.Collections.Generic;
using System.Text;

namespace Adventura.Character
{
    public abstract class Character
    {
        public string name;
        public int currentHP;
        public int maxHP;
        public int minDmg;
        public int maxDmg;
        public int level;
        public int worthXP;
        public bool physicalDMGImmunity = false;
        public bool magicalDMGImmunity = false;
        public int physicalDMGReduction = 0;
        public int magicalDMGRecuction = 0;

        public void DealDamage(Character target)
        {
            Random damage = new Random();
            target.currentHP -= damage.Next(minDmg, maxDmg);
        }

        public void UseDamageSpell(Character target, Spell.DamageSpell spell)
        {
            Random damage = new Random();
            target.currentHP -= damage.Next(spell.minDmg, spell.maxDmg);
        }

        public void UseHealingSpell(Character target, Spell.HealingSpell spell)
        {
            Random heal = new Random();
            int doHeal = heal.Next(spell.minHeal, spell.maxHeal);
            if (target.currentHP + doHeal < target.maxHP)
                target.currentHP += doHeal;
            else
                target.currentHP = target.maxHP;
        }

    }
}
