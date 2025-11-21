using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class UnitVectorDemo : Demo
    {
        private GraphicsDevice device;

        public UnitVectorDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.UnitVector)
        {
            this.device = device;
        }
    }
}