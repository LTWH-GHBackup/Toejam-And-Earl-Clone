using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class IdentityMatrixDemo : Demo
    {
        private GraphicsDevice device;

        public IdentityMatrixDemo(GraphicsDevice device)
            : base(device, 0,0, Name.IdentityMatrix)
        {
            this.device = device;
        }
    }
}