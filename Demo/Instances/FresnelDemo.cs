using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class FresnelDemo : Demo
    {
        private GraphicsDevice device;

        public FresnelDemo(GraphicsDevice device)
            : base(device, 0,0, Name.Fresnel)
        {
            this.device = device;
        }
    }
}