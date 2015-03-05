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
        public IBuff[] Buffs { get; set; }

        public void StartBattle()
        {
            while (true)
            {
                PerformFirstAction();

                //if the monster is dead
                if (player.NextAction.IsPerformed && !mob.IsAlive)
                {
                    Victor = typeof(Player);
                    break;
                }
                //if the player is dead
                else if (mob.NextAction.IsPerformed && !player.IsAlive)
                {
                    Victor = typeof(Mob);
                    break;
                }

                //Otherwise perform the other action
                if (player.NextAction.IsPerformed)
                {
                    mob.NextAction.Perform();
                }
                else
                {
                    player.NextAction.Perform();
                }

                //if the player is dead, end game
                //if the monster is dead, end battle
                //Apply status effects
                //Decrement buffs, remove if no more turns remaing
            } 
        }
        private void PerformFirstAction()
        {
            if (player.NextAction.Priority > mob.NextAction.Priority)
            {
                //Player priority greater
                player.NextAction.Perform();
            }
            else if (player.NextAction.Priority < mob.NextAction.Priority)
            {
                //Mob priority greater
                mob.NextAction.Perform();
            }
            else
            {
                //Priority equal
                if (player.Speed > mob.Speed)
                {
                    //Player speed greater
                    player.NextAction.Perform();
                }
                else if (player.Speed < mob.Speed)
                {
                    //Mob speed greater
                    mob.NextAction.Perform();
                }
                else
                {
                    //Speed equal
                    Random r = new Random();
                    if (r.Next(0, 2) == 0)
                    {
                        player.NextAction.Perform();
                    }
                    else
                    {
                        mob.NextAction.Perform();
                    }
                }
            }
        }
        private void PerformPlayerAction()
        {
            player.NextAction.Perform();
            if (player.NextAction is IBuff)
            {

            }
        }
        private void PeformMobAction()
        {

        }
        private void CheckAliveStatus()
        {

        }
    }
}
