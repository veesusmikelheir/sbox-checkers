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
        public override void FrameSimulate(Client cl)
        {
            base.FrameSimulate(cl);
            if (cl.Pawn == null) return;
            cl.Pawn.EyeRot = Input.Rotation;
        }

        public override void Respawn()
        {
            base.Respawn();
            Camera = new FunnyCamera();
        }

        public override void Simulate(Client cl)
        {
            base.Simulate(cl);
            if (cl.Pawn == null) return;
            cl.Pawn.EyeRot = Input.Rotation;
        }
    }
}
