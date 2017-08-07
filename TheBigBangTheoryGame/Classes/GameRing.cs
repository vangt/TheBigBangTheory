﻿using System;
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
            string playersNumbers = Console.ReadLine();

            if (playersNumbers == "1")
            {
                Console.WriteLine("You choose 1 player mode.");
                Console.WriteLine("Please enter player 1 information.");
                GetPlayerInfo();
                Players playerAI = new Players();
                playerAI.name = "Player 2 AI";
                playerAI.score = 0;
                playerAI.isAI = true;
                players.Add(playerAI);
                Console.WriteLine("WELCOME TO THE WORLD ROCK, PAPER, SCISSORS, LIZARD, AND SPOCK COMPETITIONS!!!  WE HAVE OUR PLAYERS. PLAYER " + players[0] + " VS " + players[1] + "!!!! THE COMPETITION IS BEST 2 OUT OF 3! NOW LET THE GAMES BEGIN!!!");
                Console.ReadLine();
                StartGame();
            }
            else if(playersNumbers == "2")
            {
                Console.WriteLine("Please enter player 1 information.");
                GetPlayerInfo();
                Console.WriteLine("Please enter player 2 information.");
                GetPlayerInfo();
                Console.WriteLine("WELCOME TO THE WORLD ROCK, PAPER, SCISSORS, LIZARD, AND SPOCK COMPETITIONS!!!  WE HAVE OUR PLAYERS. PLAYER " + players[0] + " VS " + players[1] + "!!!! THE COMPETITION IS BEST 2 OUT OF 3! NOW LET THE GAMES BEGIN!!!");
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
            Players player = new Players();
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
                string player1 = GetChoices(1);
                string player2;

                if (players[1].isAI == true)
                {
                    player2 = GetChoices(0);
                }
                else
                {
                    player2 = GetChoices(1);
                }

                GetOutCome(player1, player2);
            }
        }

        public string GetChoices(int number)
        {
            Console.WriteLine("Player please choose your selection.");
            Console.WriteLine("Choose a number \n 1: Rock \n 2: Paper \n 3: Scissors \n 4: Lizard \n 5: Spock \n");

            string choice = GetNumber(number);

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
                    choice = GetChoices(number);
                    return choice;
            }
        }

        public string GetNumber(int number)
        {
            string answer;

            if (number == 1)
            {
                answer = Console.ReadLine();
            }
            else
            {
                Random random = new Random();
                answer = random.Next(1, 5).ToString();
            }

            return answer;
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
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
            else if (player2 == "Lizard" || player2 == "Scissors")
            {
                Console.WriteLine(players[0].name + " won! Rock beats " + player2 + ". Sorry " + players[1].name);
                players[0].score += 1;
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
            else
            {
                Console.WriteLine(players[0].name + " Lost! Rock does not beat " + player2 + ". YAA!! For " + players[1].name);
                players[1].score += 1;
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
        }

        public void GetPaper(string player2)
        {
            if (player2 == "Paper")
            {
                Console.WriteLine("It is a TIE!  You both choose Paper.");
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
            else if (player2 == "Rock" || player2 == "Spock")
            {
                Console.WriteLine(players[0].name + " won! Paper beats " + player2 + ".  Sorry " + players[1].name);
                players[0].score += 1;
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
            else
            {
                Console.WriteLine(players[0].name + " Lost! Paper does not beat " + player2 + ". YAA!!! for " + players[1].name);
                players[1].score += 1;
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
        }

        public void GetScissors(string player2)
        {
            if (player2 == "Scissors")
            {
                Console.WriteLine("It is a TIE!  You both choose Scissors.");
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
            else if (player2 == "Paper" || player2 == "Lizard")
            {
                Console.WriteLine(players[0].name + " won! Scissors beats " + player2 + ". Sorry " + players[1].name);
                players[0].score += 1;
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
            else
            {
                Console.WriteLine(players[0].name + " Lost! Scissors does not beat " + player2 + ". YAA!!! For " + players[1].name);
                players[1].score += 1;
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
        }

        public void GetLizard(string player2)
        {
            if (player2 == "Lizard")
            {
                Console.WriteLine("It is a TIE!  You both choose Lizard.");
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
            else if (player2 == "Paper" || player2 == "Spock")
            {
                Console.WriteLine(players[0].name + " won! Lizard beats " + player2 + ". Sorry " + players[1].name);
                players[0].score += 1;
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
            else
            {
                Console.WriteLine(players[0].name + " Lost! Lizard does not beat " + player2 + ". YAA!!! For " + players[1].name);
                players[1].score += 1;
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
        }

        public void GetSpock(string player2)
        {
            if (player2 == "Spock")
            {
                Console.WriteLine("It is a TIE!  You both choose Spock.");
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
            else if (player2 == "Rock" || player2 == "Scissors")
            {
                Console.WriteLine(players[0].name + " won! Rock beats " + player2 + ". Sorry " + players[1].name);
                players[0].score += 1;
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
            else
            {
                Console.WriteLine(players[0].name + " Lost! Spock does not beat " + player2 + ". YAA!!! For " + players[1].name);
                players[1].score += 1;
                ScoreSheet();
                Console.ReadLine();
                StartGame();
            }
        }

        public void ScoreSheet()
        {
            Console.WriteLine(players[0].name + ": " + players[0].score + " to " + players[1].name +": " + players[1].score);
        }
    }
}
