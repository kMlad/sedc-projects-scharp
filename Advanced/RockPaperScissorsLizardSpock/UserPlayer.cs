using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class UserPlayer : Player
    {

        private int finalMove;
        private bool isFinalMove;
        public override GameMove ChooseMove()
        {
            Console.Clear();
            Console.WriteLine("Please enter a move:");
            Console.WriteLine("1)Rock | 2)Paper | 3)Scissors | 4)Lizard | 5)Spock");

            while(true)
            {
                isFinalMove = int.TryParse(Console.ReadLine(), out finalMove);
                if (isFinalMove)
                {
                    if (finalMove > 0 && finalMove < 6) break;
                    else Console.WriteLine("Please enter a valid move:");
                }
                else
                {
                    Console.WriteLine("Please enter a valid move:");
                }
            }

            switch (finalMove)
            {
                case 1: return GameMove.Rock;
                case 2: return GameMove.Paper;
                case 3: return GameMove.Scissors;
                case 4: return GameMove.Lizard;
                case 5: return GameMove.Spock;
                default: throw new ApplicationException("That's not a middle finger, that's an index finger! Still not a valid move tho.");
            }
        }
    }
}
