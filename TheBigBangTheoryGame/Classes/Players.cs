using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBigBangTheoryGame.Classes
{
    public class Players
    {
        public string name;

        public double score;

        public bool isAI;

        public Players()
        {
        }

        public virtual string GetChoice()
        {
            Console.WriteLine("Player please choose your selection.");
            Console.WriteLine("Choose a number \n 1: Rock \n 2: Paper \n 3: Scissors \n 4: Lizard \n 5: Spock \n");

            string choice = Console.ReadLine();

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
                    Console.WriteLine("You did not choose a number on the list.");
                    choice = this.GetChoice();
                    return choice;
            }
        }
    }
}
