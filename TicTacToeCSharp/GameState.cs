using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeCSharp.Players;

namespace TicTacToeCSharp
{
    public class GameState
    {
        public X X = new X();
        public O O = new O();
        public List<string> Row1 = new List<string> { "", "", "" };
        public List<string> Row2 = new List<string> { "", "", "" };
        public List<string> Row3 = new List<string> { "", "", "" };
        public bool WinnerExists = false;
        
    }    

}
