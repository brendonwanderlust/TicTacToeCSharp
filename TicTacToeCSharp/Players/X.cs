using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCSharp.Players
{
    public class X : PlayerBase
    {
        public X()
            : base(PlayerType.X)
        {
            Symbol = "X";
        }
    }
}
