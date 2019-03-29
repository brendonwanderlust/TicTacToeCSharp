using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeCSharp.Players;

namespace TicTacToeCSharp
{
    public class GameLogic
    {

        public static void SetSymbolAtLocation(GameState game, PlayerBase player, int xAxis, int yAxis)
        {
            if (yAxis == 1)
            {
                game.Row1[(xAxis - 1)] = player.Symbol;
            }
            else if (yAxis == 2)
            {
                game.Row2[(xAxis - 1)] = player.Symbol;
            }
            else if (yAxis == 3)
            {
                game.Row3[(xAxis - 1)] = player.Symbol;
            }
            else
            {
                Console.WriteLine("Data error");
            }
        }

        public static bool HasLocationAlreadyBeenSelected(GameState game, int xAxis, int yAxis)
        {
            if (yAxis == 1)
            {
                if (string.IsNullOrEmpty(game.Row1[xAxis - 1]))
                {
                    return false;
                }
            }
            else if (yAxis == 2)
            {
                if (string.IsNullOrEmpty(game.Row2[xAxis - 1]))
                {
                    return false;
                }
            }
            else if (yAxis == 3)
            {
                if (string.IsNullOrEmpty(game.Row3[xAxis - 1]))
                {
                    return false;
                }
            }            
            return true;
        }

        public static void CheckForWinner(GameState game)
        {
            HorizontalCheck(game);
            VericalCheck(game);
            DiagonalCheck(game);            
        }

        public static void VericalCheck(GameState game)
        {
            var rows = new List<List<string>> { game.Row1, game.Row2, game.Row3 };
            var list = new List<string>();
            for (var i = 0; i < rows.Count; i++)
            {
                foreach (var row in rows)
                {
                    list.Add(row[i]);
                    
                }
                if (list.Any(o => o != list[0]))
                {
                    game.WinnerExists = true;
                    break;
                }
                list.Clear();
            }          
                
        }

        public static void DiagonalCheck(GameState game)
        {
            var diagonal1 = new List<string> { game.Row1[0], game.Row2[1] , game.Row3[2] };
            var diagonal2 = new List<string> { game.Row1[2], game.Row2[1], game.Row3[0] };

            if (diagonal1.Any(o => o != diagonal1[0]) || diagonal2.Any(o => o != diagonal2[0]))
            {
                game.WinnerExists = true;                
            }
        }

        private static void HorizontalCheck(GameState game)
        {
            var rows = new List<List<string>> { game.Row1 , game.Row2 , game.Row3 };            

            foreach (var row in rows)
            {
                if (row.All(o => o == row[0]))
                {
                    game.WinnerExists = true;
                    break;
                }                
            }
            
        }
    }
}
