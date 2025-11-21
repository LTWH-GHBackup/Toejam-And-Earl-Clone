using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;

namespace ToeJamAndEarlFirstBatch
{
    public class BasicGraphicsComponent : GraphicsComponent
    {
        public Sprite _sprite;
        //public Vector2 _position;
        public float _uniformScale;
        public BasicGraphicsComponent(Sprite sprite, ref Func<Vector2> position, float uniformScale)
            : base(ref position, uniformScale)
        {
            _sprite = sprite;
            _uniformScale = uniformScale;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_sprite._texture, _position.Invoke(), _sprite._rectangle,
                             Color.White, 0, new Vector2(0, 0), _uniformScale, SpriteEffects.None,
                             0.0f);
        }

        public override void Update(GameTime gameTime)
        {
        }
    }
}
