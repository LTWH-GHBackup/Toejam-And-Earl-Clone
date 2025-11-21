using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class VectorSubtractionDemo : Demo
    {
        private GraphicsDevice device;

        public VectorSubtractionDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.VectorSubtraction)
        {
            this.device = device;
        }
    }
}