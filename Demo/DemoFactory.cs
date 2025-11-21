using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.MediaFoundation;
using SharpDX.Win32;

namespace ToeJamAndEarlFirstBatch
{
    public class DemoFactory
    {
        public static ref GameObject AddWholeObject(DemoOrder order, ref GameManager gameMan,
            ref GameIndexer indexer, GraphicsDevice device, ref GameObject gObject)
        {
            TextureManager textMan = gameMan.GetTextureManager();
            RectangleManager rectMan = gameMan.GetRectangleManager();
            CollisionManager CollisionMan = gameMan.GetCollisionManager();
            Texture2D texture = null;
            //GameObject gObject = null;
            Component component = null;

            MemoryPool pool = gameMan.GetMemoryPool();

            // Texture
            switch (order.textureType)
            {
                case TextureObjectType.Arrow:
                    //Texture2D pixel = new Texture2D(device, 1, 1);
                    //pixel.SetData([Color.White]);
                    //textMan.Add(0, pixel);
                    break;
            }


            //textMan.Add(indexer.GetTextureIndex(order.objectType), texture);
            //
            //// Rectangle
            //rectMan.AddBasedOnPattern(indexer.GetRectangleIndex(order.objectType),
            //indexer.getRectangleInputPattern(order.objectType));
            
            ComponentArrayMap map = null;
            Component.TypeID[] array;
            // Game Object
            switch (order.objectType)
            {
                case GameObjectType.LittleGuy:
                    array = [Component.TypeID.Audio,
                             Component.TypeID.AI,
                             Component.TypeID.Collision,
                             Component.TypeID.Gameplay,
                             Component.TypeID.Graphics,
                             Component.TypeID.Physics];
                    map = new((int)Component.TypeID.SIZE, array);


                    FileStream stream = FileManager.GetFile("Little_guy_sprites.png");
                    textMan.Add(indexer.GetTextureIndex(order.textureType), Texture2D.FromStream(device, stream));

                    gObject = new Little_Guy(ref indexer,
                        ref textMan.Find(indexer.GetTextureIndex(order.textureType)),
                    ref gameMan.GetRectangleManager(), false);
                    break;
                case GameObjectType.Arrow:
                    array = [Component.TypeID.Audio,
                             Component.TypeID.Collision,
                             Component.TypeID.Gameplay,
                             Component.TypeID.Graphics,
                             Component.TypeID.Physics,
                    ];
                    map = new((int)Component.TypeID.SIZE, array);
                    Vector2 origin = Vector2.Zero; 
                    Vector2 pos = Vector2.Zero; 
                    //gObject = new Arrow(ref map, ref indexer, ref gameMan.GetTextureManager(),
                    //ref gameMan.GetRectangleManager(), origin, pos);
                    break;

            }
            //gObject = DemoGameObjectFactory.CreateGameObject(ref order, ref gameMan);

            // Collision
            component = gameMan.GetMemoryPool().GetCollisionObject(order.collisionType, ref indexer);
            gObject.AddComponent(Component.TypeID.Collision, ref component);
            return ref gObject;
        }

        //public static GameObject AddGameObject(DemoOrder order, ref ManagerList list)
        //{
        //    TextureManager textMan = list.GetTextureManager();
        //    RectangleManager rectMan = list.GetRectangleManager();
        //    GameManager gameObjectMan = list.GetGameObjectManager();
        //    PhysicsManager physicsObjectMan = list.GetPhysicsObjectManager();
        //
        //    gameObjectMan.AddObject();
        //}
    }
}
