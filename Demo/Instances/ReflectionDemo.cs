using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class ReflectionDemo : Demo
    {
        private GraphicsDevice device;

        public ReflectionDemo(GraphicsDevice device)
            : base(device, 0,0, Name.Reflection)
        {
            this.device = device;
        }
    }
}