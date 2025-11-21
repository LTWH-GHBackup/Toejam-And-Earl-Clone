using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class RightAngleWithDotDemo : Demo
    {
        private GraphicsDevice device;

        public RightAngleWithDotDemo(GraphicsDevice device)
            : base(device, 0,0, Name.RightAngleWithDot)
        {
            this.device = device;
        }
    }
}