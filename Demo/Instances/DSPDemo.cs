using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class DSPDemo : Demo
    {
        private GraphicsDevice device;

        public DSPDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.DSP)
        {
            this.device = device;
        }
    }
}