using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessDungeon
{

    //The player in a monster controlled by the user.
    public class Player : Monster
    {
        public int Experience { get; set; }

        public Player(int hp = 100, int mp = 50, int attackDamage = 10, int magicDamage = 10, int armor = 5, int magicResist = 5,
                      int armorPenetration = 0, int magicPenetration = 0, int speed = 10)
        {
            CurrentHP = hp;
            MaxHP = hp;
            CurrentMP = mp;
            MaxMP = mp;
            AttackDamage = attackDamage;
            MagicDamage = magicDamage;
            Armor = armor;
            MagicResist = magicResist;
            ArmorPenetration = armorPenetration;
            MagicPenetration = magicPenetration;
            Speed = speed;
            Level = 1;
        }
    }
}
