using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    public class VectorDemo : Demo
    {
        public VectorDemo(GraphicsDevice graphics) 
            : base(graphics, 1, 1, Name.Vector)
        {
            GraphicsComponent graphicsComponent0 = null;
            GraphicsBatch graphicsBatch0 = null;

            // ----------------------------------------------------------------
            // Adding Objects
            // ----------------------------------------------------------------
            DemoOrder order = new DemoOrder();
            GameIndexer indexer = new GameIndexer((Name)this.getName());

            order.objectType = GameObjectType.Arrow;
            order.textureType = TextureObjectType.Arrow;
            order.rectangles = [0];
            order.collisionType = CollisionInstanceType.Null;

            GameObject gObject = null;
            int uh = 0;

            OftenReusedDemo.AddTexturesHelpers(_GameMan.GetTextureManager(), graphics, ref uh);

            Vector2 origin = Vector2.Zero;
            Vector2 direction = new Vector2(100, 100);

            gObject = new Arrow(ref indexer,ref this._GameMan.GetTextureManager(),
                    ref this._GameMan.GetRectangleManager(), origin, direction);

            graphicsBatch0 = new GraphicsBatch(graphics);

            graphicsComponent0 = (GraphicsComponent)gObject.GetComponent((int)Component.TypeID.Graphics);
            graphicsBatch0.AddGraphicsComponent(ref graphicsComponent0);

            _GameMan.AttachGraphicsBatch((int)GameManager.State.gameplay, ref graphicsBatch0);
            _GameMan.AddObject(GameManager.State.gameplay, ref gObject);
            Arrow arrow = gObject as Arrow;
            // ----------------------------------------------------------------
            // Adding Inputs
            // ----------------------------------------------------------------
            BindList bindList = new BindList(10);

            SpaceKey space = new(Keys.Space, ref bindList);
            space.AddInputEvent(KeyState.JUSTPRESSED, () =>
            {
                arrow.SwapMoveLocation();
            });

            LeftKey left = new(Keys.Left, ref bindList);
            left.AddInputEvent(KeyState.HELD, () => {
                arrow.Move(Arrow.Direction.LEFT);
            });

            RightKey right = new(Keys.Right, ref bindList);
            right.AddInputEvent(KeyState.HELD, () => {
                arrow.Move(Arrow.Direction.RIGHT);
            });

            UpKey up = new(Keys.Up, ref bindList);
            up.AddInputEvent(KeyState.HELD, () => {
                arrow.Move(Arrow.Direction.UP);
            });

            DownKey down = new(Keys.Down, ref bindList);
            down.AddInputEvent(KeyState.HELD, () => {
                arrow.Move(Arrow.Direction.DOWN);
            });

            InputManager.AddBindList((Name)this.getName(), ref bindList);
        }
    }
}
