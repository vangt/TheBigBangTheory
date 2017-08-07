using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBigBangTheoryGame.Classes
{
    public class GameRing
    {
        List<Players> players = new List<Players>();

        public GameRing()
        { 
        }

        public void GetNumberOfPlayers()
        {
            Console.WriteLine("Is there 1 or 2 players?");
            int playersNumbers = int.Parse(Console.ReadLine());

            if (playersNumbers == 1)
            {
                Console.WriteLine("You choose 1 player mode.");
                GetPlayerInfo();
                Players playerAI = new Players();
                playerAI.name = "Player 2 AI";
                playerAI.score = 0;
                playerAI.isAI = true;
                players.Add(playerAI);
            }
            else
            {
                GetPlayerInfo();
                GetPlayerInfo();
            }

            StartGame();
        }

        public void GetPlayerInfo()
        {
            Players player = new Players();
            player.name = Console.ReadLine();
            player.score = 0;
            players.Add(player);
        }


    }
}
