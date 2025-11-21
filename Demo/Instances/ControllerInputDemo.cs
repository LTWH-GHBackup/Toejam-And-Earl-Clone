using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class ControllerInputDemo : Demo
    {
        private GraphicsDevice device;

        public ControllerInputDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.ControllerInput)
        {
            this.device = device;
        }
    }
}