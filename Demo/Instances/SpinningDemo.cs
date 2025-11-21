using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToeJamAndEarlFirstBatch
{
    public class SpinningDemo : Demo
    {
        public SpinningDemo(GraphicsDevice graphics) 
        : base(graphics, 1, 32, Name.Spinning)
        {
            GraphicsComponent graphicsComponent0 = null;
            GraphicsBatch graphicsBatch0 = null;

            // ----------------------------------------------------------------
            // Adding Objects
            // ----------------------------------------------------------------
            DemoOrder order = new DemoOrder();
            GameIndexer indexer = new GameIndexer((Name)this.getName());

            order.objectType = GameObjectType.LittleGuy;
            order.textureType = TextureObjectType.LittleGuy;
            order.rectangles = [0];
            order.collisionType = CollisionInstanceType.Null;

            GameObject gObject = null;
            int uh = 0;

            OftenReusedDemo.AddRectangles_16pxby16px_4by4(_GameMan.rectangleManager);

            FileStream stream = FileManager.GetFile("Little_guy_sprites.png");
            _GameMan.textureManager.Add(indexer.GetTextureIndex(order.textureType), Texture2D.FromStream(graphics, stream));

            gObject = new Little_Guy(ref indexer, ref this._GameMan.textureManager.Find(indexer.GetTextureIndex(order.textureType)),
                    ref this._GameMan.GetRectangleManager(), true);

            graphicsBatch0 = new GraphicsBatch(graphics);

            graphicsComponent0 = (GraphicsComponent)gObject.GetComponent((int)Component.TypeID.Graphics);
            graphicsBatch0.AddGraphicsComponent(ref graphicsComponent0);

            _GameMan.AttachGraphicsBatch((int)GameManager.State.gameplay, ref graphicsBatch0);
            _GameMan.AddObject(GameManager.State.gameplay, ref gObject);
            Little_Guy guy = gObject as Little_Guy;

            // ----------------------------------------------------------------
            // Adding Inputs
            // ----------------------------------------------------------------
            BindList bindList = new BindList(10);

            SpaceKey space = new(Keys.Space, ref bindList);

            LeftKey left = new(Keys.Left, ref bindList);
            left.AddInputEvent(KeyState.HELD, () => {
                guy.Move(LittleGuyDirection.LEFT);
            });

            RightKey right = new(Keys.Right, ref bindList);
            right.AddInputEvent(KeyState.HELD, () => {
                guy.Move(LittleGuyDirection.RIGHT);
            });

            UpKey up = new(Keys.Up, ref bindList);
            up.AddInputEvent(KeyState.HELD, () => {
                guy.Move(LittleGuyDirection.BACK);
            });

            DownKey down = new(Keys.Down, ref bindList);
            down.AddInputEvent(KeyState.HELD, () => {
                guy.Move(LittleGuyDirection.FRONT);
            });

            InputManager.AddBindList((Name)this.getName(), ref bindList);
        }
    }
}
