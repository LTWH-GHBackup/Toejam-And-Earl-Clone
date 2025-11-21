using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;

namespace ToeJamAndEarlFirstBatch
{
    public class SimpleGraphics : GraphicsComponent
    {
        Sprite _sprite;
        public Func<Vector2> _position;
        public Func<Vector2> _direction;

        public SimpleGraphics(Texture2D texture, Rectangle rectangle, ref Func<Vector2> position)
            : base(ref position, 1)
        {
            _sprite = new Sprite(texture, rectangle);
            _position = position;
            //_direction = direction;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_sprite._texture, _position.Invoke(), _sprite._rectangle,
                Color.White, 0, new Vector2(0, 0), _UniformScale, SpriteEffects.None,
                0.0f);
        }
    }
}
