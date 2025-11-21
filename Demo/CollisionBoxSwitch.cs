using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    public class CollisionBoxSwitch : Demo
    {
        public CollisionBoxSwitch(GraphicsDevice device)
            : base(device, 4, 33, Name.CollisionBoxSwitch)
        {
            //GameIndexer indexer = new GameIndexer(Name.CollisionBoxSwitch);
            //
            //TextureManager textureManager = this._GameMan.GetTextureManager(); 
            //RectangleManager rectangleManager = this._GameMan.GetRectangleManager(); 
            //
            //int helperCounter = 0;
            //OftenReusedDemo.AddTextures0(textureManager, device, true, ref helperCounter);
            //OftenReusedDemo.AddRectangles_16pxby16px_4by4(rectangleManager);
            //int textureCollision = helperCounter;
            //OftenReusedDemo.AddTextureCollisionBox(ref textureManager, device, ref helperCounter);
            //
            //Component.TypeID[] array = [Component.TypeID.Audio,
            //                            Component.TypeID.Collision,
            //                            Component.TypeID.Gameplay,
            //                            Component.TypeID.Graphics,
            //                            Component.TypeID.Physics];
            //ComponentArrayMap map = new((int)Component.TypeID.SIZE, array);
            //Little_Guy lil = OftenReusedDemo.AddLilGuy(device, ref map, ref textureManager, ref rectangleManager, true, ref helperCounter, indexer);
            //
            //GraphicsBatch batchGameplay0 = new GraphicsBatch(device);
            //GraphicsComponent g_comp = (GraphicsComponent)lil.GetComponent((int)Component.TypeID.Graphics);
            //batchGameplay0.AddGraphicsComponent(ref g_comp);
            //GameObject refG = lil;
            //
            //_GameMan.AddObject(GameManager.State.gameplay, ref refG);
            //_GameMan.AttachGraphicsBatch((int)GameManager.State.gameplay, ref batchGameplay0);
            //
            //// Hahaha duh
            //int scale = 4;
            //Vector2 dimensions = lil.GetScale() * new Vector2(16, 16);
            ////Vector2 dimensions = new Vector2(16, 16);
            //Component box0 = new CollisionAABB(ref textureManager.Find(textureCollision), ref rectangleManager.Find(0), scale, () => lil.GetPosition(), dimensions);
            //lil.AddComponent(Component.TypeID.Collision, ref box0);
            //
            //BindList bindList = new BindList(10);
            //SpaceKey space = new(Keys.Space, ref bindList);
            //LeftKey left = new(Keys.L, ref bindList);
            //InputManager.AddBindList(Name.CollisionBoxSwitch, ref bindList);
            //
            //lil.SetBehavior((int)Little_Guy.Behaviors.DoNothing);
        }
    }
}