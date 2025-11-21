using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    //using InventorySpace = InventoryItem[];

    internal class InventoryDemo : Demo
    {
        public InventoryDemo(GraphicsDevice graphics, int preferredBackBufferHeight, int preferredBackBufferWidth)
            : base(graphics, 1, 1, Name.Inventory)
        {
            GraphicsComponent graphicsComponent0 = null;
            GraphicsBatch graphicsBatch0 = null;

            // ----------------------------------------------------------------
            // Adding Objects
            // ----------------------------------------------------------------
            DemoOrder order = new DemoOrder();
            GameIndexer indexer = new GameIndexer((Name)this.getName());

            order.objectType    = GameObjectType.Inventory;
            order.textureType   = TextureObjectType.HUD;
            order.rectangles    = [0];
            order.collisionType = CollisionInstanceType.Null;

            GameObject gObject  = null;
            int uh = 0;

            int x = 0;
            int y = 400;
            Vector2 position = new Vector2(x, y);

            x = 341;
            y = 220;

            _GameMan.rectangleManager.Add(0, new Rectangle(x, y, 322, 78));

            FileStream stream = FileManager.GetFile("HUD_display.png");
            _GameMan.textureManager.Add(indexer.GetTextureIndex(order.textureType),
                                        Texture2D.FromStream(graphics, stream));

            // ----------------------------------------------------------------
            // Inventory
            // ----------------------------------------------------------------

            gObject = new Inventory(
                ref indexer, 
                ref this._GameMan.GetTextureManager(),
                ref this._GameMan.GetRectangleManager(),
                position,
                preferredBackBufferHeight, 
                preferredBackBufferWidth);

            graphicsBatch0 = new GraphicsBatch(graphics);

            graphicsComponent0 = 
                (GraphicsComponent)gObject.GetComponent((int)Component.TypeID.Graphics);
            graphicsBatch0.AddGraphicsComponent(ref graphicsComponent0);

            Inventory inv = gObject as Inventory;
            InventoryGameplay invGame = 
                (InventoryGameplay)(inv.GetComponent((int)Component.TypeID.Gameplay));

            InventoryItem[] inventorySpace = inv.GetInventorySpace();
            foreach(InventoryItem item in inventorySpace)
            {
                GraphicsComponent graphicComponent0 = 
                    (GraphicsComponent)item.GetComponent((int)(GameplayComponent.TypeID.Graphics));
                    graphicsBatch0.AddGraphicsComponent(ref graphicComponent0);
            }

            _GameMan.AttachGraphicsBatch(
                (int)GameManager.State.gameplay,
                ref graphicsBatch0);
            _GameMan.AddObject(
                GameManager.State.gameplay,
                ref gObject);

            // ----------------------------------------------------------------
            // Adding Inputs
            // ----------------------------------------------------------------
            BindList bindList = new BindList(10);

            SpaceKey space = new(Keys.Space, ref bindList);
            space.AddInputEvent(KeyState.JUSTPRESSED, () => {
                inv.ToggleDisplay();
            });
           
            InputManager.AddBindList((Name)this.getName(), ref bindList);
        }
    }
}