using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class GOAPDemo : Demo
    {
        private GraphicsDevice device;

        public GOAPDemo(GraphicsDevice device)
            : base(device, 0,0, Name.Goap)
        {
            this.device = device;
        }
    }
}