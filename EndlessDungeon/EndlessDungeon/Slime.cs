using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessDungeon
{
    public class Slime : Mob
    {
        public Slime()
        {
            CurrentHP = 100;
            MaxHP = 100;
            CurrentMP = 0;
            MaxMP = 0;
            AttackDamage = 5;
            MagicDamage = 0;
            Armor = 20;
            MagicResist = 0;
            ArmorPenetration = 0;
            MagicPenetration = 0;
            Speed = 5;
            Level = 1;
            Name = "Slime";
        }
    }
}
