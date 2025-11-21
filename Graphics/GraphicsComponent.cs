using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public abstract class GraphicsComponent : Component
    {

        protected Func<Vector2> _position;
        protected float _UniformScale;

        public GraphicsComponent(ref Func<Vector2> position, float uniformScale)
        {
            _position = position;
            _UniformScale = uniformScale;
        }

        public void SetScale(float scale)
        {
            _UniformScale = scale;
        }

        public float GetScale()
        {
            return _UniformScale;
        }

        public virtual void Draw(SpriteBatch spriteBatch, Vector2 origin = new Vector2())
        {

        }

        public abstract void Draw(SpriteBatch spriteBatch);
    }


}
