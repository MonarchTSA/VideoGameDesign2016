using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessDungeon
{
    public abstract class Monster
    {
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int MaxMP { get; set; }
        public int CurrentMP { get; set; }
        public int AttackDamage { get; set; }
        public int MagicDamage { get; set; }
        public int Armor { get; set; }  
        public int MagicResist { get; set; }
        public int ArmorPenetration { get; set; }
        public int MagicPenetration { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }
        public bool IsAlive
        {
            get
            {
                if (CurrentHP > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public String Name { get; set; }
        public Action NextAction { get; set; }
    }
}
