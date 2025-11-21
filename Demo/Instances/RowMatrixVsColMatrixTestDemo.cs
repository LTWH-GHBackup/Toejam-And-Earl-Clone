using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class RowMatrixVsColMatrixTestDemo : Demo
    {
        private GraphicsDevice device;

        public RowMatrixVsColMatrixTestDemo(GraphicsDevice device)
            : base(device, 0,0, Name.RowMatrixVsColMatrixTest)
        {
            this.device = device;
        }
    }
}