using System.Drawing;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    internal class VectorAdditionDemo : Demo
    {
        private GraphicsDevice device;

        public VectorAdditionDemo(GraphicsDevice graphics)
            : base(graphics, 1, 1, Name.VectorAddition)
        {
            //DemoOrder order = new DemoOrder();
            //GameIndexer indexer = new GameIndexer((Name)this.getName());
            //
            //order.objectType = GameObjectType.Arrow;
            //order.textureType = TextureObjectType.Arrow;
            //order.rectangles = [0];
            //order.physicsType = PhysicsObjectType.Null;
            //
            //GameObject gObject = null;
            //int uh = 0;
            //OftenReusedDemo.AddTexturesHelpers(_list.GetTextureManager(), graphics, ref uh);
            //DemoFactory.AddWholeObject(order, ref _list, ref indexer, graphics, ref gObject);
            //
            //((Arrow)gObject).SetDirection(100, 100);
            //
            //order = new DemoOrder();
            //
            //order.objectType = GameObjectType.Arrow;
            //order.textureType = TextureObjectType.Arrow;
            //order.rectangles = [0];
            //order.physicsType = PhysicsObjectType.Null;
            //
            //OftenReusedDemo.AddTexturesHelpers(_list.GetTextureManager(), graphics, ref uh);
            //DemoFactory.AddWholeObject(order, ref _list, ref indexer, graphics, ref gObject);
            //
            //((Arrow)gObject).SetDirection(200, 100);
            //((Arrow)gObject).SetPosition(100, 100);
            //
            //BindList bindList = new BindList(10);
            //SpaceKey space = new(Keys.Space, ref bindList);
            //LeftKey left = new(Keys.L, ref bindList);
            //InputManager.AddBindList((Name)this.getName(), ref bindList);
        }
    }
}