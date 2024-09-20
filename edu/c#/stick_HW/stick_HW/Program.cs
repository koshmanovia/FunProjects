using stick_HW.Sticks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stick_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new SticksGame(10, Player.Human);
            game.MachinePlayed += Game_MachinePlayed;
            game.HumanTurnToMakeMove += Game_HumanTurnToMakeMove;
            game.EndOfGame += Game_EngOfGame;

            game.Start();
            Console.ReadLine();
        }

        private static void Game_EngOfGame(Player player)
        {
            Console.WriteLine($"winner:{player}");
        }

        private static void Game_HumanTurnToMakeMove(object sender, int remainingSticks)
        {
            Console.WriteLine($"Remainig sticks:{remainingSticks}");
            Console.WriteLine("Take some sticks");
            
            bool takenCorrectly = false;
            while (!takenCorrectly)
            {
                if (int.TryParse(Console.ReadLine(), out int takenSticks))
                {
                    var game = (SticksGame)sender;
                    try
                    {
                        game.HumanTakes(takenSticks);
                        takenCorrectly = true;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private static void Game_MachinePlayed(int sticksTake)
        {
            Console.WriteLine($"Computer took:{sticksTake}");
        }
    }
}
