using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBigBangTheoryGame.Classes
{
    public class AIPlayer : Player
    {
        public AIPlayer()
        {
            this.name = "Player 2 AI";
            this.score = 0;
            this.isAI = true;
        }

        public override string GetChoice()
        {
            string choice = "";

            Random random = new Random();
            choice = random.Next(1, 5).ToString();
            
            choice = GetRPSLS(choice);

            return choice;
        }

        public string GetRPSLS(string number)
        {
            string choice = number;

            switch (choice)
            {
                case "1":
                    choice = "Rock";
                    return choice;
                case "2":
                    choice = "Paper";
                    return choice;
                case "3":
                    choice = "Scissors";
                    return choice;
                case "4":
                    choice = "Lizard";
                    return choice;
                case "5":
                    choice = "Spock";
                    return choice;
                default:
                    return choice;
            }
        }
    }
}
