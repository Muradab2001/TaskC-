using Climbing_the_Leaderboard.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Climbing_the_Leaderboard.Services
{
    internal class Manager
    {
        private Player[] _players;
        public Manager()
        {
            _players= new Player[0];
        }
        public void AddPlayer(string name,int score)
        {
            int rank = 1;
            if (_players.Length>=1)
            {
                foreach (Player item in _players)
                {
                    if (score>item._score)
                    {
                        item._rank++;
                    }
                    else
                    {
                        rank++;
                    }
                }
            }
            Player player = new Player(name, rank, score);
            Array.Resize(ref _players, _players.Length + 1);
            _players[_players.Length - 1] = player;
        }
        public void listrank() 
        {
            foreach (Player player in _players)
            {
                Console.WriteLine($"rank:{player._rank} name:{player._name} score:{player._score}");
            }
        }
    }
}
