using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBigBangTheoryGame.Classes
{
    public class AIPlayer : Players
    {
        public AIPlayer()
        {
            this.name = "Player 2 AI";
            this.score = 0;
            this.isAI = true;
        }

        public string GetChoice()
        {
            string choice = "";

            Random random = new Random();
            choice = random.Next(1, 5).ToString();

            return choice;
        }
    }
}
