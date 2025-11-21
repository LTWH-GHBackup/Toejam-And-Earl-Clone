using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class NullGraphicsComponent : GraphicsComponent
    {
        public NullGraphicsComponent(ref Func<Vector2> position, float uniformScale) : base(ref position, uniformScale)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}