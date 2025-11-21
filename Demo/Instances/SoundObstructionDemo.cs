using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class SoundObstructionDemo : Demo
    {
        private GraphicsDevice device;

        public SoundObstructionDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.SoundObstruction)
        {
            this.device = device;
        }
    }
}