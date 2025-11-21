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
    public class FreeAngleGraphicsComponent : GraphicsComponent
    {
        Sprite _sprite;
        Func<Vector2> _Origin;
        Func<Vector2> _Direction;

        public FreeAngleGraphicsComponent(Texture2D texture, Rectangle rectangle, ref Func<Vector2> origin, ref Func<Vector2> direction)
            :base(ref origin, 1)
        {
            _sprite = new Sprite(texture, rectangle);
            _Origin = origin;
            _Direction = direction;
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            Vector2 dir = _Direction.Invoke();
            float length = dir.Length();
            float angle = (float)Math.Atan2(dir.Y, dir.X);
            Vector2 scale = new Vector2(length, 3f);
            
            //Vector2 scale = Vector2.Zero;
            //scale.X = _position.X;
            //scale.Y = 1.0f;
            
            //float dx =_Direction.X - _position.X;
            //float dy =_Direction.Y - _position.Y;
            //
            //float angle = (float)Math.Atan2(dy, dx);
            
            spriteBatch.Draw(_sprite._texture, _Origin.Invoke(), null,
                 Color.White, angle, new Vector2(0,0), scale, SpriteEffects.None,
                 0);
        }

        internal void SetDirection(int v1, int v2)
        {
            //_Direction = new Vector2(v1, v2);
        }

        internal void SetPosition(int v1, int v2)
        {
        }
    }
}
