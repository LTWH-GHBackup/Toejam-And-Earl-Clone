using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class GraphicsBatch
    {
        protected SpriteBatch _spriteBatch;
        protected List<GraphicsComponent> _components;
        
        public GraphicsBatch(GraphicsDevice device)
        {
            _spriteBatch = new SpriteBatch(device);
            _components = new();
        }

        public virtual void Draw()
        {
            _spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, samplerState: SamplerState.PointClamp);

            foreach (var component in _components)
            {
                component.Draw(_spriteBatch);
            }

            _spriteBatch.End();
        }

        internal void AddGraphicsComponent(ref GraphicsComponent g_comp)
        {
            _components.Add(g_comp);
        }
    }
}