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
    public class Pixel : GraphicsComponent
    {
        Sprite _sprite;
        private TJEColor color;

        public Pixel(Func<Vector2> posFunc, 
            TJEColor color, 
            ref Texture2D texture, 
            ref Rectangle rectangle)
            : base(ref posFunc, 1.0f)
        {

            this._sprite = new Sprite(texture, rectangle);
            this.color = color;
        }

        public Pixel(ref Func<Vector2> position, 
            float uniformScale,
            TJEColor color
            ) 
            : base(ref position, uniformScale)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            Vector2 pos = _position.Invoke();

            spriteBatch.Draw(
                _sprite._texture,
                pos,                   // world-space position
                _sprite._rectangle,    // source rect from tilesheet
                Color.White,           // no color tint
                0f,
                Vector2.Zero,
                1.0f,                  // no insane scale
                SpriteEffects.None,
                0.0f
            );

            //spriteBatch.Draw(_sprite._texture, _position.Invoke(), _sprite._rectangle,
            //Color.Green, 0, , 50.0f, SpriteEffects.None,
            //0.0f);
        }
    }
}
