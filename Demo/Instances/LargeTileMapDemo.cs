using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class LargeTileMapDemo : Demo
    {
        private GraphicsDevice device;

        public LargeTileMapDemo(GraphicsDevice device)
            : base(device, 0,0, Name.LargeTileMap)
        {
            this.device = device;
        }
    }
}