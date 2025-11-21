using System;
using System.Reflection.Metadata;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct2D1.Effects;
using SharpDX.Direct3D9;

namespace ToeJamAndEarlFirstBatch
{
    internal class InventoryGraphics : GraphicsComponent
    {
        Sprite _sprite;
        private Func<Vector2> res;

        public InventoryGraphics(Texture2D texture, Rectangle rectangle, ref Func<Vector2> res)
            : base(ref res, 1.0f)
        {
            _sprite = new Sprite(texture, rectangle);
            this.res = res;
        }

        public InventoryGraphics(ref Texture2D texture, ref Rectangle rectangleManager, ref Func<Vector2> func, float scale)
            : base(ref func, scale)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_sprite._texture, _position.Invoke(), _sprite._rectangle,
            Color.White, 0, new Vector2(0, 0), _UniformScale, SpriteEffects.None,
            0.0f);
        }
    }
}