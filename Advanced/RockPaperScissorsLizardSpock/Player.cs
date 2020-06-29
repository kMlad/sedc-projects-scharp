using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public abstract class Player
    {
        public string Name { get; set; }
        public int TotalPlayed { get; set; }
        public int TotalWins { get; set; }
        public int TotalTies { get; set; }
        public int TotalLosses { get => TotalPlayed-TotalWins-TotalTies; }
        public double WinRate { get 
                {
                if (TotalWins != 0)
                    return 100 * TotalWins / TotalPlayed;
                else return 0;
                } }
        public abstract GameMove ChooseMove();
    }
}
