using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class LocalMulltiplayerDemo : Demo
    {
        private GraphicsDevice device;

        public LocalMulltiplayerDemo(GraphicsDevice device)
            : base(device, 0,0, Name.LocalMultiplayer)
        {
            this.device = device;
        }
    }
}