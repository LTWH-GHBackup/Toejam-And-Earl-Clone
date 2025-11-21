using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class SoundWithPriorityDemo : Demo
    {
        private GraphicsDevice device;

        public SoundWithPriorityDemo(GraphicsDevice device)
            : base(device, 0, 0, Name.SoundWithPriority)
        {
            this.device = device;
        }
    }
}