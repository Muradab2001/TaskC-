using System;
using System.Collections.Generic;
using System.Text;

namespace Climbing_the_Leaderboard.Models
{
    internal class Player
    {
        public string _name { get; set; }
        public int _rank { get; set; }
        public int _score { get; set; }

        public Player(string name, int rank, int score)
        {
            _name= name;
            _rank= rank;
            _score= score;
        }
    }
}
