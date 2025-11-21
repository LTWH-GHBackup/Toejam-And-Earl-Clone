using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class DotDemo : Demo
    {
        private GraphicsDevice device;

        public DotDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.DotProduct)
        {
            this.device = device;
        }
    }
}