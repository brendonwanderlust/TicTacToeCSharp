using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCSharp.Players
{
    public abstract class PlayerBase
    {
        protected PlayerBase(PlayerType type)
        {
            Type = type;
        }

        public string Symbol { get; set; }
        public PlayerType Type { get; set; }
    }
}
