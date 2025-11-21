using System.Drawing;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    internal class StateBasedDemo : Demo
    {
        public StateBasedDemo(GraphicsDevice graphics)
            : base(graphics, 1, 32, Name.StateBased)
        {
            //DemoOrder order = new DemoOrder();
            //GameIndexer indexer = new GameIndexer((Name)this.getName());
            //
            //order.objectType = GameObjectType.LittleGuy;
            //order.textureType = TextureObjectType.LittleGuy;
            //order.rectangles = [0];
            //order.physicsType = PhysicsObjectType.Null;
            //
            //GameObject gObject = null;
            //int uh = 0;
            //OftenReusedDemo.AddRectangles_16pxby16px_4by4(_list.rectangleManager);
            //OftenReusedDemo.AddTexturesHelpers(_list.GetTextureManager(), graphics, ref uh);
            //Little_Guy guy = (Little_Guy)DemoFactory.AddWholeObject(order, ref _list, ref indexer, graphics, ref gObject);
            //// Changing from a behavior list to State
            //
            //
            ////((Little_Guy)gObject).SetBehavior(0);
            //
            //BindList bindList = new BindList(10);
            //SpaceKey space = new(Keys.Space, ref bindList);
            //LeftKey left = new(Keys.L, ref bindList);
            //InputManager.AddBindList((Name)this.getName(), ref bindList);
            //
        }
    }
}