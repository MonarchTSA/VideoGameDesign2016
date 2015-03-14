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
            player.Name = "Justin";
            Mob slime = new Slime();
            Battle battle = new Battle(player, slime);
            while (!battle.Finished)
            {
                foreach (String s in battle.TurnLog)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("Player HP: " + player.CurrentHP + "/" + player.MaxHP);
                Console.WriteLine("Slime HP: " + slime.CurrentHP + "/" + slime.MaxHP);
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");
                bool inputChosen = false;
                while (!inputChosen)
                {
                    ConsoleKeyInfo input = Console.ReadKey(true);
                    switch (input.Key)
                    {
                        case ConsoleKey.D1:
                            player.NextAction = new Attack(player, slime);
                            inputChosen = true;
                             break;
                        case ConsoleKey.D2:
                            inputChosen = true;
                            player.NextAction = new Defend(player);
                            break;
                    }
                }
                slime.NextAction = new Attack(slime, player);
                battle.NextTurn();
                Console.Clear();
            }
            Console.WriteLine(battle.Victor.Name);
            Console.ReadKey(true);
        }
    }
}
