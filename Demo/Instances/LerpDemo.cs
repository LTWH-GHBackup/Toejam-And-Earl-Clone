using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class LerpDemo : Demo
    {
        private GraphicsDevice device;

        public LerpDemo(GraphicsDevice device)
            : base(device, 0,0, Name.Lerp)
        {
            this.device = device;
        }
    }
}