using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class SoundWithFalloffDemo : Demo
    {
        private GraphicsDevice device;

        public SoundWithFalloffDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.SoundWithFalloff)
        {
            this.device = device;
        }
    }
}