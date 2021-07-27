using Sandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public partial class CheckersPlayer : Player
    {
        public override void Respawn()
        {
            base.Respawn();
            Camera = new FunnyCamera();
        }
    }
}
