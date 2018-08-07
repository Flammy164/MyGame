using System;
using System.Collections.Generic;
using System.Text;

namespace Adventura.Spell
{
    public abstract class Spell
    {
        public string name;
        public string description;
        public int manaCost;
        public MagicClass magicClass;
    }
}
