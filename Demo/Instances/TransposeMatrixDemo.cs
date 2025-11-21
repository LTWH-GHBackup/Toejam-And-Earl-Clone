using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class TransposeMatrixDemo : Demo
    {
        private GraphicsDevice device;

        public TransposeMatrixDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.TransposeMatrix)
        {
            this.device = device;
        }
    }
}