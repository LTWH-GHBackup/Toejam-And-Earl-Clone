using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class MatrixMultiplicationDemo : Demo
    {
        private GraphicsDevice device;

        public MatrixMultiplicationDemo(GraphicsDevice device)
            : base(device, 0,0, Name.MatrixMultiplication)
        {
            this.device = device;
        }
    }
}