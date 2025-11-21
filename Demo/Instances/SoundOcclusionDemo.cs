using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class SoundOcclusionDemo : Demo
    {
        private GraphicsDevice device;

        public SoundOcclusionDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.SoundOcclusion)
        {
            this.device = device;
        }
    }
}