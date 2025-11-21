using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.MediaFoundation;
using SharpDX.Win32;

namespace ToeJamAndEarlFirstBatch
{
    public class OftenReusedDemo
    {
        public static void AddTextures0(TextureManager textureManager, GraphicsDevice device)
        {
            FileStream stream = FileManager.GetFile("Floor_path_tiles.png");
            textureManager.Add(0, Texture2D.FromStream(device, stream));

            stream = FileManager.GetFile("Little_guy_sprites.png");
            textureManager.Add(1, Texture2D.FromStream(device, stream));
        }
        public static void AddTextures0(TextureManager textureManager, GraphicsDevice device, bool v,ref int helperCounter)
        {
            FileStream stream = FileManager.GetFile("Floor_path_tiles.png");
            textureManager.Add(helperCounter, Texture2D.FromStream(device, stream));
            helperCounter++;
        }

        public static void AddRectangles_16pxby16px_4by4(RectangleManager rectangleManager)
        {
            int n = 32;
            int x = 0;
            int y = 0;
            for (int i = 0; i < n; ++i)
            {
                rectangleManager.Add(i, new Rectangle(x * 16, y * 16, 16, 16));
                ++x;
                if ((i + 1) % 4 == 0)
                {
                    ++y;
                    x = 0;
                }
            }
        }

        public static void AddTexturesHelpers(TextureManager textureManager, GraphicsDevice device, ref int helperCounter)
        {
            Texture2D pixel = new Texture2D(device, 1, 1);
            pixel.SetData([Color.White]);
            textureManager.Add(0, pixel);
        }


        public static ref Arrow AddArrow(GameManager gameManager)
        {
            throw new NotImplementedException();
        }

        public static Wall AddWall(ref ComponentArrayMap map, ref TextureManager textureManager, ref RectangleManager rectangleManager, bool v, ref int helperCounter)
        {
            Vector2 pos = new Vector2(300, 0);
            Vector2 dimensions = new Vector2(400, 400);

            rectangleManager.Add(33, new Rectangle((int)pos.X, (int)pos.Y,
                (int)dimensions.X, (int)dimensions.Y));
            Wall wall = new Wall(ref map, ref textureManager.Find(helperCounter), ref rectangleManager.Find(33), ref pos);
            return wall;
        }

        public static void AddRectangle_Wall(RectangleManager rectangleManager)
        {
        }

        public static void AddTextureCollisionBox(ref TextureManager textureManager, GraphicsDevice device, ref int helperCounter)
        {
            //FileStream stream = FileManager.GetFile("BlackBorder.png");
            FileStream stream = FileManager.GetFile("rgba-compose.png");
            textureManager.Add(helperCounter, Texture2D.FromStream(device, stream));
            helperCounter++;
        }

    }
}
