using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class SingleAxisScrollingDemo : Demo
    {
        private GraphicsDevice device;

        public SingleAxisScrollingDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.SingleAxisScrolling)
        {
            this.device = device;
        }
    }
}