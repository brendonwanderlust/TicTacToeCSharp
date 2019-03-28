using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCSharp.Players
{
    public class O : PlayerBase
    {
        public O()
            : base(PlayerType.X)
        {
            Symbol = "O";
        }
    }
}