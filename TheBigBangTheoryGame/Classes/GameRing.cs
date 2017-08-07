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
            int playersNumbers = int.Parse(Console.ReadLine());

            if (playersNumbers == 1)
            {
                Console.WriteLine("You choose 1 player mode.");
                Console.WriteLine("Please enter player 1 information.");
                GetPlayerInfo();
                Players playerAI = new Players();
                playerAI.name = "Player 2 AI";
                playerAI.score = 0;
                playerAI.isAI = true;
                players.Add(playerAI);
            }
            else
            {
                Console.WriteLine("Please enter player 1 information.");
                GetPlayerInfo();
                Console.WriteLine("Please enter player 2 information.");
                GetPlayerInfo();
            }

            Console.WriteLine("WELCOME TO THE WORLD ROCK, PAPER, SCISSORS, LIZARD, AND SPOCK COMPETITIONS!!!  WE HAVE OUR PLAYERS. PLAYER " + players[0] + " VS " + players[1] + "!!!! THE COMPETITION IS BEST 2 OUT OF 3! NOW LET THE GAMES BEGIN!!!");
            Console.ReadLine();
            StartGame();
        }

        public void GetPlayerInfo()
        {
            Players player = new Players();
            player.name = Console.ReadLine();
            player.score = 0;
            players.Add(player);
        }

        public void StartGame()
        {
            
            if (players[0].score == 2)
            {
                Console.WriteLine("Player 1 WINS!!!");
                Console.ReadLine();
            }
            else if (players[1].score == 2)
            {
                Console.WriteLine("Player 2 WINS!!!");
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
            Console.WriteLine("Choose a number \n 1: Rock \n 2: Paper \n 3: Scissor \n 4: Lizard \n 5: Spock \n");

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
                    choice = "Scissor";
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
    }
}
