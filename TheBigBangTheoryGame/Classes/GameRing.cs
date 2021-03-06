﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBigBangTheoryGame.Classes
{
    public class GameRing
    {
        List<Player> players = new List<Player>();

        public GameRing()
        { 
        }

        public void GetNumberOfPlayers()
        {
            Console.WriteLine("Is there 1 or 2 players?");
            string playersNumbers = Console.ReadLine();

            if (playersNumbers == "1")
            {
                Console.WriteLine("You choose 1 player mode.");
                Console.WriteLine("Please enter player 1 information.");
                GetPlayerInfo();
                AIPlayer playerAI = new AIPlayer();
                players.Add(playerAI);
                Console.WriteLine("WELCOME TO THE WORLD ROCK, PAPER, SCISSORS, LIZARD, AND SPOCK COMPETITIONS!!!  WE HAVE OUR PLAYERS. PLAYER " + players[0].name + " VS " + players[1].name + "!!!! \n THE COMPETITION IS BEST 2 OUT OF 3! NOW LET THE GAMES BEGIN!!!");
                Console.ReadLine();
                StartGame();
            }
            else if(playersNumbers == "2")
            {
                Console.WriteLine("Please enter player 1 information.");
                GetPlayerInfo();
                Console.WriteLine("Please enter player 2 information.");
                GetPlayerInfo();
                Console.WriteLine("WELCOME TO THE WORLD ROCK, PAPER, SCISSORS, LIZARD, AND SPOCK COMPETITIONS!!!  WE HAVE OUR PLAYERS. PLAYER " + players[0].name + " VS " + players[1].name + "!!!! \n THE COMPETITION IS BEST 2 OUT OF 3! NOW LET THE GAMES BEGIN!!!");
                Console.ReadLine();
                StartGame();
            }
            else
            {
                Console.WriteLine("You did not input 1 or 2. Please choose again.");
                GetNumberOfPlayers();
            }
        }

        public void GetPlayerInfo()
        {
            Player player = new Player();
            Console.WriteLine("Please enter your name.");
            player.name = Console.ReadLine();
            player.score = 0;
            players.Add(player);
        }

        public void StartGame()
        {
            
            if (players[0].score == 2)
            {
                Console.WriteLine("WE HAVE OUR CHAMPION!!!" + players[0].name + " WINS!!!");
                Console.ReadLine();
            }
            else if (players[1].score == 2)
            {
                Console.WriteLine("WE HAVE OUT CHAMPION!!!" + players[1].name + " WINS!!!");
                Console.ReadLine();
            }
            else
            {
                string player1 = players[0].GetChoice();
                string player2;

                if (players[1].isAI == true)
                {
                    player2 = players[1].GetChoice();
                    Console.WriteLine("Player 2 AI has made it's choice.");
                }
                else
                {
                    player2 = players[1].GetChoice();
                }

                GetOutCome(player1, player2);
            }
        }

        public void GetOutCome(string player1, string player2)
        {
            Console.WriteLine("The choices have been made!");
            Console.ReadLine();

            switch (player1)
            {
                case "Rock":
                    GetRock(player2);
                    break;
                case "Paper":
                    GetPaper(player2);
                    break;
                case "Scissors":
                    GetScissors(player2);
                    break;
                case "Lizard":
                    GetLizard(player2);
                    break;
                case "Spock":
                    GetSpock(player2);
                    break;
                default:
                    break;
            }
        }

        public void GetRock(string player2)
        {
            if (player2 == "Rock")
            {
                Console.WriteLine("It is a TIE!  Both players choose Rock.");
                GetTie();
            }
            else if (player2 == "Lizard" || player2 == "Scissors")
            {
                Console.WriteLine(players[0].name + " won! Rock beats " + player2 + ". Sorry " + players[1].name);
                UpdatePlayerOne();
            }
            else
            {
                Console.WriteLine(players[0].name + " Lost! Rock does not beat " + player2 + ". YAA!! For " + players[1].name);
                UpdatePlayerTwo();
            }
        }

        public void GetPaper(string player2)
        {
            if (player2 == "Paper")
            {
                Console.WriteLine("It is a TIE!  You both choose Paper.");
                GetTie();
            }
            else if (player2 == "Rock" || player2 == "Spock")
            {
                Console.WriteLine(players[0].name + " won! Paper beats " + player2 + ".  Sorry " + players[1].name);
                UpdatePlayerOne();
            }
            else
            {
                Console.WriteLine(players[0].name + " Lost! Paper does not beat " + player2 + ". YAA!!! for " + players[1].name);
                UpdatePlayerTwo();
            }
        }

        public void GetScissors(string player2)
        {
            if (player2 == "Scissors")
            {
                Console.WriteLine("It is a TIE!  You both choose Scissors.");
                GetTie();
            }
            else if (player2 == "Paper" || player2 == "Lizard")
            {
                Console.WriteLine(players[0].name + " won! Scissors beats " + player2 + ". Sorry " + players[1].name);
                UpdatePlayerOne();
            }
            else
            {
                Console.WriteLine(players[0].name + " Lost! Scissors does not beat " + player2 + ". YAA!!! For " + players[1].name);
                UpdatePlayerTwo();
            }
        }

        public void GetLizard(string player2)
        {
            if (player2 == "Lizard")
            {
                Console.WriteLine("It is a TIE!  You both choose Lizard.");
                GetTie();
            }
            else if (player2 == "Paper" || player2 == "Spock")
            {
                Console.WriteLine(players[0].name + " won! Lizard beats " + player2 + ". Sorry " + players[1].name);
                UpdatePlayerOne();
            }
            else
            {
                Console.WriteLine(players[0].name + " Lost! Lizard does not beat " + player2 + ". YAA!!! For " + players[1].name);
                UpdatePlayerTwo();
            }
        }

        public void GetSpock(string player2)
        {
            if (player2 == "Spock")
            {
                Console.WriteLine("It is a TIE!  You both choose Spock.");
                GetTie();
            }
            else if (player2 == "Rock" || player2 == "Scissors")
            {
                Console.WriteLine(players[0].name + " won! Rock beats " + player2 + ". Sorry " + players[1].name);
                UpdatePlayerOne();
            }
            else
            {
                Console.WriteLine(players[0].name + " Lost! Spock does not beat " + player2 + ". YAA!!! For " + players[1].name);
                UpdatePlayerTwo();
            }
        }

        public void GetTie()
        {
            ScoreSheet();
            Console.ReadLine();
            StartGame();
        }

        public void UpdatePlayerOne()
        {
            players[0].score += 1;
            ScoreSheet();
            Console.ReadLine();
            StartGame();
        }

        public void UpdatePlayerTwo()
        {
            players[1].score += 1;
            ScoreSheet();
            Console.ReadLine();
            StartGame();
        }

        public void ScoreSheet()
        {
            Console.WriteLine(players[0].name + ": " + players[0].score + " to " + players[1].name +": " + players[1].score);
        }
    }
}