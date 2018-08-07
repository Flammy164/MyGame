using Adventura.Character;
using Adventura.Action;
using System;
using System.Collections.Generic;

namespace Adventura
{
    class Program
    {
        public static string name;
        static void Main(string[] args)
        {
            Console.Write("Enter your warrior name: ");
            name = Console.ReadLine();
            Player player = new Player("Janus", 50, 1, 45, 49);
            NPC nonplayer = new NPC("Brouk", 50, 1, 10);
            player.DealDamage(nonplayer);
            Console.WriteLine(nonplayer.currentHP);
            nonplayer.DealDamage(player);
            player.UseHealingSpell(nonplayer, new Spell.HealingSpell(100, 100, Spell.MagicClass.nature));
            Console.WriteLine(nonplayer.currentHP);
    }
    }
}