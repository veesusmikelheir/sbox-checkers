using Sandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class FunnyCamera : Camera
    {
        public override void Update()
        {
            var pawn = Local.Pawn;
            if (pawn == null) return;
            Rot = pawn.EyeRot * Quaternion.CreateFromYawPitchRoll(0,0,Time.Tick);
            Pos = pawn.EyePos;

            FieldOfView = 90;
            Viewer = pawn;
        }
    }
}
