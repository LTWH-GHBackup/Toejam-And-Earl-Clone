using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct2D1;
using ToeJamAndEarlFirstBatch.Gameplay;

namespace ToeJamAndEarlFirstBatch
{
    public class CameraGraphicsBatch : GraphicsBatch
    {
        Camera _camera;

        public CameraGraphicsBatch(GraphicsDevice device, ref Camera camera) : base(device)
        {
            _camera = camera;
        }

        public CameraGraphicsBatch(GraphicsDevice device) : base(device)
        {
        }

        public void AttachCamera(ref Camera camera)
        {
            _camera = camera;
        }

        public override void Draw()
        {
            _spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, samplerState: SamplerState.PointClamp, transformMatrix: _camera.GetViewMatrix());

            foreach (var component in _components)
            {
                component.Draw(_spriteBatch);
            }

            _spriteBatch.End();
        }
    }
}
