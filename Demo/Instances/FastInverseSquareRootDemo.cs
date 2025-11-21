using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class FastInverseSquareRootDemo : Demo
    {
        private GraphicsDevice device;

        public FastInverseSquareRootDemo(GraphicsDevice device)
            : base(device, 0,0, Name.FastInverseSquareRoot)
        {
            this.device = device;
        }
    }
}