using System;
using BattleshipModellingPractice.Objects;
using BattleshipModellingPractice.Objects.Games;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipModellingPractice_master
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many games you want to play?");
            var numGames =1;// int.Parse(Console.ReadLine());
            Game game = new Game();
            game.PlayToEnd();            
        }
    }
}
