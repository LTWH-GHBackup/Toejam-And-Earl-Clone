using System.Drawing;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    internal class DrawingAPictureDemo : Demo
    {
        public DrawingAPictureDemo(GraphicsDevice graphics)
            : base(graphics, 1, 2, Name.DrawingAPicture)
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
            //BindList bindList = new BindList(10);
            //UpKey up = new(Keys.Up, ref bindList); 
            //DownKey down = new(Keys.Down, ref bindList);
            //
            //InputManager.AddBindList((Name)this.getName(), ref bindList);
        }
    }
}