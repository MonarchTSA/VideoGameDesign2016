using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EndlessDungeon;

namespace EndlessDungoenTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Mob slime = new Slime();
            Battle battle = new Battle(player, slime);
            while (!battle.Finished)
            {
                Console.WriteLine("Player HP: " + player.CurrentHP + "/" + player.MaxHP);
                Console.WriteLine("Slime HP: " + slime.CurrentHP + "/" + slime.MaxHP);
                player.NextAction = new Attack(player, slime);
                slime.NextAction = new Attack(slime, player);
                battle.NextTurn();
            }
            Console.WriteLine(battle.Victor.Name);
            Console.ReadKey();
        }
    }
}
