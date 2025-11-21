using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class DeveloperMode : Demo
    {
        private GraphicsDevice device;

        public DeveloperMode(GraphicsDevice device)
            : base(device, 0, 0, Name.DeveloperMode)

        {
            this.device = device;
        }
    }
}