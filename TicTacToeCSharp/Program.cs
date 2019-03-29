using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            GameState game = new GameState();
            UI.InitializeGame(game);                        
        }
    }
}
