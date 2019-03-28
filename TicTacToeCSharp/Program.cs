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

            Game game = new Game();
            game.InitializeGame();
            game.PlacePiece(game.X, 1, 1);
            UI.GameBoardComponent(game);
        }
    }
}
