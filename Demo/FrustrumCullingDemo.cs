using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class FrustrumCullingDemo : Demo
    {
        private GraphicsDevice device;

        public FrustrumCullingDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.FrustrumCulling)
        {
            this.device = device;
        }
    }
}