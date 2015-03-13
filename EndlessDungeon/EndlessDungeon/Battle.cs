using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessDungeon
{
    public class Battle
    {
        public Mob mob { get; set; }
        public Player player { get; set; }
        public Type Victor { get; set; }
        public bool Finished { get; set; }
        public Type FastestMonster
        {
            get
            {
                if (player.NextAction.Priority > mob.NextAction.Priority)
                {
                    //Player priority greater
                    return typeof(Player);
                }
                else if (player.NextAction.Priority < mob.NextAction.Priority)
                {
                    //Mob priority greater
                    return typeof(Mob);
                }
                else
                {
                    //Priority equal
                    if (player.Speed > mob.Speed)
                    {
                        //Player speed greater
                        return typeof(Player);
                    }
                    else if (player.Speed < mob.Speed)
                    {
                        //Mob speed greater
                        return typeof(Mob);
                    }
                    else
                    {
                        //Speed equal
                        Random r = new Random();
                        if (r.Next(0, 2) == 0)
                        {
                            return typeof(Player);
                        }
                        else
                        {
                            return typeof(Mob);
                        }
                    }
                }
            }
        }
        public List<IBuff> Buffs { get; set; }

        public Battle(Player player, Mob mob)
        {
            this.player = player;
            this.mob = mob;
            Finished = false;
            Buffs = new List<IBuff>();
        }

        public void NextTurn()
        {
            PerformAction(FastestMonster);
                
            if (WhoIsAlive()) { return; }

            //Peform the action of the other monster
            if (FastestMonster == typeof(Player))
            {
                PerformAction(typeof(Mob));
            }
            else
            {
                PerformAction(typeof(Player));
            }
                
            if (WhoIsAlive()) { return; }

            UpdateStatusEffects();
            UpdateBuffs();
        }

        private void PerformAction(Type t)
        {
            if (t == typeof(Player))
            {
                player.NextAction.Perform();
                if (player.NextAction is IBuff)
                {
                    Buffs.Add((IBuff)player.NextAction);
                }
            }
            else
            {
                mob.NextAction.Perform();
                if (mob.NextAction is IBuff)
                {
                    Buffs.Add((IBuff)mob.NextAction);
                }
            }
        }

        //returns true if someone is not alive, false if everyone is alive
        private bool WhoIsAlive()
        {
            if (player.IsAlive && !mob.IsAlive)
            {
                Victor = typeof(Player);
                Finished = true;
                return true; 
            }
            else if (mob.IsAlive && !player.IsAlive)
            {
                Victor = typeof(Mob);
                Finished = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UpdateStatusEffects() { }

        private void UpdateBuffs()
        {
            foreach (IBuff buff in Buffs.ToList())
            {
                buff.Length--;
                if (buff.Length == 0)
                {
                    buff.RemoveBuff();
                    Buffs.Remove(buff);
                }
            }
        }
    }
}
