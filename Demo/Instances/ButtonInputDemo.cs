using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    internal class ButtonInputDemo : Demo
    {
        public ButtonInputDemo(GraphicsDevice device)
            : base(device, 0,0, Name.ButtonInput)
        {
            BindList bindList = new BindList(10);
            SpaceKey space = new(Keys.Space, ref bindList);
            LeftKey left = new(Keys.L, ref bindList);
            InputManager.AddBindList((Name)this.getName(), ref bindList);
        }
    }
}