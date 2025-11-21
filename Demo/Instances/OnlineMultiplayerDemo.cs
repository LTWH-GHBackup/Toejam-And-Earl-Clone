using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class OnlineMultiplayerDemo : Demo
    {
        private GraphicsDevice device;

        public OnlineMultiplayerDemo(GraphicsDevice device)
            : base(device, 0,0, Name.OnlineMultiplayer)
        {
            this.device = device;
        }
    }
}