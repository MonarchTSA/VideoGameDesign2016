using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessDungeon
{
    public class Attack : Action
    {

        public Monster Reciever { get; set; }
        public int Damage { get; set; }
        public bool CriticalStrike
        {
            get
            {
                Random r = new Random();
                if (r.Next(0, 101) <= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public String Message
        {
            get
            {
                return Sender.Name + " attacked " + Reciever.Name + " for " + Damage + " damage!";
            }
        }

        public Attack(Monster sender, Monster reciever) 
        {
            Sender = sender;
            Reciever = reciever;
        }

        public override void Perform()
        {
            double DamageMultiplier = 100d / (100 + (Reciever.Armor - Sender.ArmorPenetration));
            Damage = (int)((double)(Sender.AttackDamage) * DamageMultiplier);
            if (CriticalStrike)
            {
                Damage *= 2;
            }
            Reciever.CurrentHP -= Damage;
        }
    }
}
