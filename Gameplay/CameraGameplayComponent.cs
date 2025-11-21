using System;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch.Gameplay
{
    internal class CameraGameplayComponent : GameplayComponent
    {
        private Func<Vector2> posFunc;

        public CameraGameplayComponent(ref Func<Vector2> posFunc)
        {
            this.posFunc = posFunc;
        }

        public override void Update(GameTime gameTime)
        {
            this.SetPosition(posFunc.Invoke());
        }
    }
}