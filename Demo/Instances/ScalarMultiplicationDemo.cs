using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class ScalarMultiplicationDemo : Demo
    {
        private GraphicsDevice device;

        public ScalarMultiplicationDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.LocalMultiplayer)
        {
            this.device = device;
        }
    }
}