using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class InventoryItemGraphics : GraphicsComponent
    {
        private Func<Vector2> posFunc;
        Sprite sprite;

        public InventoryItemGraphics(ref Func<Vector2> position, float uniformScale) : base(ref position, uniformScale)
        {
        }

        public InventoryItemGraphics(ref Texture2D texture2D,
            ref Rectangle rectangle, 
            ref Func<Vector2> posFunc, 
            float scale)
            : base(ref posFunc, scale)
        {
            sprite = new Sprite(texture2D, rectangle);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
        }
        
        public void SwapGraphics(ref Texture2D texure)
        {

        }
    }
}