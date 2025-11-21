using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class SwarmDemo : Demo
    {
        private GraphicsDevice device;

        public SwarmDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.Swarm)
        {
            this.device = device;
        }
    }
}