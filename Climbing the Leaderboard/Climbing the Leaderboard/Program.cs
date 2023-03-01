using Climbing_the_Leaderboard.Services;
using System;

namespace Climbing_the_Leaderboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.AddPlayer("test",200);
            manager.AddPlayer("test1", 250);
            manager.AddPlayer("test2", 40);
            manager.listrank();
        }
    }
}
