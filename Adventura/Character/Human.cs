using System;
using System.Collections.Generic;
using System.Text;

namespace Adventura.Character
{
    class Human : Character
    {
        public bool isMale;
        public int currentMana;
        public int maxMana;
        public int gold;
        public List<Spell.Spell> spellbook;
    }
}
