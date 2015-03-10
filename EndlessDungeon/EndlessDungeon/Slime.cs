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
            CurrentHP = 20;
            MaxHP = 20;
            CurrentMP = 0;
            MaxMP = 0;
            AttackDamage = 5;
            MagicDamage = 0;
            Armor = 5;
            MagicResist = 0;
            ArmorPenetration = 0;
            MagicPenetration = 0;
            Speed = 5;
            Level = 1;
        }
    }
}
