using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class CrossProductDemo : Demo
    {
        private GraphicsDevice device;

        public CrossProductDemo(GraphicsDevice device)
            : base(device, 0,0, Name.CrossProduct)
        {
            this.device = device;
        }
    }
}