using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace Task3
{
    class CPUPlayer : Player
    {
        private Random rnd = new Random();  
        
        public int FinalMove { get;  set; }
        public override GameMove ChooseMove()
        {
            FinalMove = rnd.Next(1, 11);
            switch (FinalMove)
            {
                case 1: return GameMove.Rock;
                case 2: return GameMove.Paper;
                case 3: return GameMove.Scissors;
                case 4: return GameMove.Lizard;
                case 5: return GameMove.Spock;
                case 6: return GameMove.Rock;
                case 7: return GameMove.Paper;
                case 8: return GameMove.Scissors;
                case 9: return GameMove.Lizard;
                case 10: return GameMove.Spock;
                default: throw new ApplicationException("Error: 'Middle Finger' is not a move.");
            }
        }
    }
}
