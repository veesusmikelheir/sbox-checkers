using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox;

namespace Checkers
{
    public partial class CheckersGame : Game
    {
        public override void ClientJoined(Client cl)
        {
            base.ClientJoined(cl);
            cl.Pawn = new CheckersPlayer();
        }
    }
}
