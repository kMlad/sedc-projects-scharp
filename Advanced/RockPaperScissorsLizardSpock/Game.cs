using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public enum GameMove { Rock, Paper, Scissors, Lizard, Spock }
     
    class Game
    {
        #region Inits and Ctor
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }

        public Game(Player playerOne, Player playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }
        #endregion
        #region Play Methods
        public void PlayerOneWins()
        {
            PlayerOne.TotalWins++;
            PlayerOne.TotalPlayed++;
            PlayerTwo.TotalPlayed++;
            Console.WriteLine($"{PlayerOne.Name} wins!");
        }
        public void PlayerTwoWins()
        {
            PlayerTwo.TotalWins++;
            PlayerOne.TotalPlayed++;
            PlayerTwo.TotalPlayed++;
            Console.WriteLine($"{PlayerTwo.Name} wins!");
        }
        public void GameTie()
        {
            PlayerOne.TotalPlayed++;
            PlayerTwo.TotalPlayed++;
            PlayerOne.TotalTies++;
            PlayerTwo.TotalTies++;
            Console.WriteLine("The game is tied. Try again.");
        }


        public void ApplyGameLogic(GameMove move1, GameMove move2)
        {
            //Tie
            if(move1==move2)
            {
                GameTie();
            }
            //Rock crushes Scissors and Lizard
            else if(move1==GameMove.Rock)
            {
                if(move2==GameMove.Scissors || move2==GameMove.Lizard)
                {
                    PlayerOneWins();
                }
                else
                {
                    PlayerTwoWins();
                }
            }
            //Paper covers Rock, disproves Spock
            else if(move1==GameMove.Paper)
            {
                if(move2==GameMove.Rock || move2==GameMove.Spock)
                {
                    PlayerOneWins();
                }
                else
                {
                    PlayerTwoWins();
                }
            }
            //Scissors cuts Paper, decaptitates Lizard
            else if (move1 == GameMove.Scissors)
            {
                if (move2 == GameMove.Paper || move2 == GameMove.Lizard)
                {
                    PlayerOneWins();
                }
                else
                {
                    PlayerTwoWins();
                }
            }
            //Lizard eats Paper, poisons Spock
            else if (move1 == GameMove.Lizard)
            {
                if (move2 == GameMove.Paper || move2 == GameMove.Spock)
                {
                    PlayerOneWins();
                }
                else
                {
                    PlayerTwoWins();
                }
            }
            //Spock vaporizez Rock, smashes Spock
            else if (move1 == GameMove.Spock)
            {
                if (move2 == GameMove.Rock || move2 == GameMove.Scissors)
                {
                    PlayerOneWins();
                }
                else
                {
                    PlayerTwoWins();
                }
            }
        }
        #endregion
        #region MenuMethods
        public void Play()
        {
            Console.Clear();
            GameMove move1 = PlayerOne.ChooseMove();
            GameMove move2 = PlayerTwo.ChooseMove();
            Console.WriteLine($"{PlayerOne.Name}'s {move1} VS {PlayerTwo.Name}'s {move2}");

            ApplyGameLogic(move1, move2);
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();

            //Enter main meny

        }
        public void ShowStats()
        {
            Console.Clear();
            Console.WriteLine($"{PlayerOne.Name} wins: {PlayerOne.TotalWins} | {PlayerTwo.Name} wins: {PlayerTwo.TotalWins} | Ties: {PlayerOne.TotalTies}");
            Console.WriteLine($"{PlayerOne.Name} win percentage: {PlayerOne.WinRate}%");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        #endregion



    }
}
