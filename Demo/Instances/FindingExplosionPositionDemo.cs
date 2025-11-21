using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class FindingExplosionPositionDemo : Demo
    {
        private GraphicsDevice device;

        public FindingExplosionPositionDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.FindingExplosionPosition)
        {

            this.device = device;
        }
    }
}