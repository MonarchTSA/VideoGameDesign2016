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
        public bool CriticalStrike { get; set; }
        public override String Message
        {
            get
            {
                if (CriticalStrike)
                {
                    return "A critical hit! " + Sender.Name + " attacked " + Reciever.Name + " for " + Damage + " damage!";
                }
                else
                {
                    return Sender.Name + " attacked " + Reciever.Name + " for " + Damage + " damage!";
                }
            }
        }
        private static Random r = new Random();

        public Attack(Monster sender, Monster reciever) 
        {
            Sender = sender;
            Reciever = reciever;
        }

        public override void Perform()
        {
            double DamageMultiplier = 100d / (100 + (Reciever.Armor - Sender.ArmorPenetration));
            Damage = (int)((double)(Sender.AttackDamage) * DamageMultiplier);
            if (r.Next(0, 101) <= 10)
            {
                Damage *= 2;
                CriticalStrike = true;
            }
            Reciever.CurrentHP -= Damage;
        }
    }
}
