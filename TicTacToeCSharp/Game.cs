using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeCSharp.Players;

namespace TicTacToeCSharp
{
    public class Game
    {
        public X X = new X();
        public O O = new O();
        public List<string> Row1 = new List<string> { "", "", "" };
        public List<string> Row2 = new List<string> { "", "", "" };
        public List<string> Row3 = new List<string> { "", "", "" };


        public void PlacePiece( PlayerBase player, int xAxis, int yAxis )
        {
            if (yAxis == 1)
            {
                Row1.Insert((xAxis - 1), player.Symbol);
            }
            else if (yAxis == 2)
            {
                Row2.Insert((xAxis - 1), player.Symbol);
            }
            else if (yAxis == 3)
            {
                Row3.Insert((xAxis - 1), player.Symbol);
            }
            else
            {
                Console.WriteLine("Data error");
            }
        }

        public void InitializeGame()
        {
            
        }

        
    }

    
}
