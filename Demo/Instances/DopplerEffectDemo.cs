using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class DopplerEffectDemo : Demo
    {
        private GraphicsDevice device;

        public DopplerEffectDemo(GraphicsDevice device)
            : base(device, 0,0, Name.DopplerEffect)
        {
            this.device = device;
        }
    }
}