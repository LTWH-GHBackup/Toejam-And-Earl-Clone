using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    public class CollisionDemo : Demo
    {
        Little_Guy lil = null;
        Wall rightWall = null;


        public CollisionDemo(GraphicsDevice device) :
            base(device, 6, 34, Name.Collision)
        {
            //int helperCounter = 0;
            //
            //OftenReusedDemo.AddTextures0(this.textureManager, device, true, ref helperCounter);
            //
            //int textureWhite = helperCounter;
            //OftenReusedDemo.AddTexturesHelpers(this.textureManager, device, ref helperCounter);
            //
            //int textureCollision = helperCounter;
            //OftenReusedDemo.AddTextureCollisionBox(ref this.textureManager, device, ref helperCounter);
            //
            //OftenReusedDemo.AddRectangles_16pxby16px_4by4(this.rectangleManager);
            //
            //Component.TypeID[] array = [Component.TypeID.Audio,
            //                            Component.TypeID.Collision,
            //                            Component.TypeID.Gameplay,
            //                            Component.TypeID.Graphics,
            //                            Component.TypeID.Physics];
            //ComponentArrayMap map = new((int)Component.TypeID.SIZE, array);
            //
            //lil = OftenReusedDemo.AddLilGuy(device, ref map,ref this.textureManager, ref this.rectangleManager, true, ref helperCounter);
            //
            //map = new((int)Component.TypeID.SIZE, array);
            //rightWall = OftenReusedDemo.AddWall(ref map, ref this.textureManager, ref this.rectangleManager, true, ref helperCounter);
            //
            //GameObject refG = lil;
            //this.gameManager.AddObject(ref refG);
            //refG = rightWall;
            //this.gameManager.AddObject(ref refG);
            //
            //int scale = 4;
            //Vector2 dimensions = lil.GetScale() * new Vector2(16, 16);
            ////Vector2 dimensions = new Vector2(16, 16);
            //Component box0 = new CollisionAABB(ref textureManager.Find(textureCollision), ref rectangleManager.Find(0), scale, () => lil.GetPosition(), dimensions);
            //lil.AddComponent(Component.TypeID.Collision, ref box0);
            //
            //scale = 1;
            ////Vector2 dimensions = new Vector2(16, 16);
            //dimensions = new Vector2(400, 400);
            //box0 = new CollisionAABB(ref textureManager.Find(textureCollision), ref rectangleManager.Find(0), scale, () => rightWall.GetPosition(), dimensions);
            //rightWall.AddComponent(Component.TypeID.Collision, ref box0);
            //
            //
            //BindList bindList = new BindList(10);
            //SpaceKey space = new(Keys.Space, ref bindList);
            //LeftKey left = new(Keys.L, ref bindList);
            //InputManager.AddBindList(Name.Collision, ref bindList);
            //
            //SubscriberList subscriberList = new SubscriberList();
            //subscriberList.AddAction(() =>
            //{
            //    lil.SetNextAction(1);
            //});
            //
            //CollisionComponent collisionComponent0 = (CollisionComponent)lil.GetComponent((int)Component.TypeID.Collision);
            //CollisionComponent collisionComponent1 = (CollisionComponent)rightWall.GetComponent((int)Component.TypeID.Collision);
            //
            //collisionManager.AddCollisionPair(ref collisionComponent0,
            //    ref collisionComponent1,
            //    ref subscriberList);
            //
            //lil.SetBehavior((int)Little_Guy.Behaviors.RunIntoWall);
        }
    }
}
