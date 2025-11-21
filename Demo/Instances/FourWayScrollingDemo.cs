using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ToeJamAndEarlFirstBatch.Gameplay;

namespace ToeJamAndEarlFirstBatch
{
    internal class FourWayScrollingDemo : Demo
    {
        public FourWayScrollingDemo(GraphicsDevice graphics, int preferredBackBufferHeight, int preferredBackBufferWidth)
            : base(graphics, 2,33, Name.FourWayScrolling)
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

            Texture2D pixel = new Texture2D(graphics, 1, 1);
            pixel.SetData([Color.Green]);
            _GameMan.textureManager.Add(1, pixel);

            Vector2 position = new Vector2(preferredBackBufferWidth / 2, preferredBackBufferHeight / 2);

            // ----------------------------------------------------------------
            // Player -- LittleGuy
            // ----------------------------------------------------------------
            graphicsBatch0 = new CameraGraphicsBatch(graphics);

            gObject = new Little_Guy(ref indexer,
                ref this._GameMan.textureManager.Find(indexer.GetTextureIndex(order.textureType)),
                ref this._GameMan.GetRectangleManager(), 
                true);

            graphicsComponent0 = (GraphicsComponent)gObject.GetComponent((int)Component.TypeID.Graphics);
            graphicsBatch0.AddGraphicsComponent(ref graphicsComponent0);

            _GameMan.AttachGraphicsBatch((int)GameManager.State.gameplay, 
                ref graphicsBatch0);
            _GameMan.AddObject(GameManager.State.gameplay, 
                ref gObject);

            Little_Guy guy = gObject as Little_Guy;
            GameplayComponent gaComp = guy.GetComponent((int)Component.TypeID.Gameplay) as GameplayComponent;
            gaComp.SetPosition(position);

            // ----------------------------------------------------------------
            // Camera
            // ----------------------------------------------------------------

            GameplayComponent guyGC = (GameplayComponent)guy.GetComponent((int)Component.TypeID.Gameplay);
            Func<Vector2> posFunc = () => guyGC.GetPosition();
            gObject = new Camera(ref indexer,
                ref this._GameMan.GetTextureManager(),
                ref this._GameMan.GetRectangleManager(),
                posFunc,
                preferredBackBufferWidth,
                preferredBackBufferHeight
                );

            Camera camera = gObject as Camera;

            ((CameraGraphicsBatch)graphicsBatch0).AttachCamera(ref camera);

            _GameMan.AddObject(GameManager.State.gameplay,
                ref gObject);

            // ----------------------------------------------------------------
            // Level
            // ----------------------------------------------------------------

            gObject = new Level0(ref indexer, 
                ref this._GameMan.GetTextureManager(), 
                ref this._GameMan.GetRectangleManager(),
                position
                );

            graphicsComponent0 =
                (GraphicsComponent)gObject.GetComponent((int)Component.TypeID.Graphics);
            graphicsBatch0.AddGraphicsComponent(ref graphicsComponent0);

            TJETileMap aTJETileMap = (TJETileMap)graphicsComponent0;
            List<Pixel> tiles = aTJETileMap.GetTiles();
            
            
            for ( int i = 0; i < tiles.Count; i++ )
            {
                graphicsComponent0 = tiles[i] as GraphicsComponent;
                graphicsBatch0.AddGraphicsComponent(ref graphicsComponent0);
            }
            //_GameMan.AddObject(
            //    GameManager.State.gameplay,
            //    ref gObject);

            // ----------------------------------------------------------------
            // Adding Inputs
            // ----------------------------------------------------------------
            BindList bindList = new BindList(10);

            SpaceKey space = new(Keys.Space, ref bindList);
            space.AddInputEvent(KeyState.JUSTPRESSED, () => {
            });

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