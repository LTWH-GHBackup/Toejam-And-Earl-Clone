using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    public class PerimeterRunDemo : Demo
    {
        Little_Guy lil = null;
        public PerimeterRunDemo(GraphicsDevice device)
        : base(device, 1, 32, Name.PerimeterRun)
        {
            // ----------------------------------------------------------------
            // Adding Objects
            // ----------------------------------------------------------------
            DemoOrder order = new DemoOrder();
            GameIndexer indexer = new GameIndexer((Name)this.getName());
            GraphicsComponent graphicsComponent0 = null; 

            order.objectType = GameObjectType.LittleGuy;
            order.textureType = TextureObjectType.LittleGuy;
            order.rectangles = [0];
            order.collisionType = CollisionInstanceType.Null;

            GameObject gObject = null;
            int uh = 0;

            OftenReusedDemo.AddRectangles_16pxby16px_4by4(_GameMan.rectangleManager);
            OftenReusedDemo.AddTexturesHelpers(_GameMan.GetTextureManager(), device, ref uh);
            gObject = DemoFactory.AddWholeObject(order, ref _GameMan, ref indexer, device, ref gObject);
            _GameMan.AddObject(GameManager.State.gameplay, ref gObject);
            
            GraphicsBatch graphicsBatch0 = new GraphicsBatch(device);

            graphicsComponent0 = (GraphicsComponent)gObject.GetComponent((int)Component.TypeID.Graphics);
            graphicsBatch0.AddGraphicsComponent(ref graphicsComponent0);

            _GameMan.AttachGraphicsBatch((int)GameManager.State.gameplay, ref graphicsBatch0);
            // ----------------------------------------------------------------

            // ----------------------------------------------------------------
            // Setting input settings
            // ----------------------------------------------------------------
            BindList bindList = new BindList(10);
            SpaceKey space = new(Keys.Space, ref bindList);
            LeftKey left = new(Keys.L, ref bindList);
            InputManager.AddBindList((Name)this.getName(), ref bindList);
            // ----------------------------------------------------------------

            // ----------------------------------------------------------------
            // Setting up Behavior
            // ----------------------------------------------------------------
            ((Little_Guy)gObject).SetBehavior(0);
            // ----------------------------------------------------------------



        }
    }
}
